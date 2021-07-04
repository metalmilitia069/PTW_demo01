using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : ShipBase
{
    [Header("Player Stats:")]
    public ShipStats_SO shipStats_SO;
    public UIManager_SO uIManager_SO;

    // Start is called before the first frame update
    private void Awake()
    {
        _speed = shipStats_SO.playerSpeed;
        _fireRate = shipStats_SO.fireRate;

        _playerControls = new PlayerControls();
        gameManager_SO.shipStats = this;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();        
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    public void TakeDamage()
    {
        
        if (shipStats_SO.playerShield <= 0)
        {
            if (shipStats_SO.playerHealth <= 1)
            {
                shipStats_SO.playerHealth--;
                IsPlayerDead();
            }
            else
            {
                shipStats_SO.playerHealth--;
            }
        }
        else
        {
            shipStats_SO.playerShield--;
        }

        uIManager_SO.canUpdadeHp = true;

        //if (shipStats_SO.playerHealth <= 1)
        //{
        //    shipStats_SO.playerHealth--;
        //    uIManager_SO.canUpdadeHp = true;
        //    IsPlayerDead();
        //}
        //else
        //{
        //    shipStats_SO.playerHealth--;
        //    uIManager_SO.canUpdadeHp = true;
        //}
    }

    public void LevelUp()
    {
        if (shipStats_SO.playerLevel >= shipStats_SO.maxLevel)
        {
            return;
        }

        shipStats_SO.playerLevel++;
        shipStats_SO.playerHealth = shipStats_SO.playerLevel + 2;
        shipStats_SO.levelUpThreshold += (int)(shipStats_SO.levelUpThreshold * 1.5f);
        shipStats_SO.levelingUpXp = 0;
    }

    public void AddXp(int XpToAdd)
    {
        shipStats_SO.playerXPCumulated += XpToAdd;
        shipStats_SO.playerScore += XpToAdd;
        shipStats_SO.levelingUpXp += XpToAdd;

        shipStats_SO.levelProgressionRate = shipStats_SO.levelingUpXp / shipStats_SO.levelUpThreshold;

        if (shipStats_SO.levelProgressionRate >= 1)
        {
            LevelUp();
        }
    }
}
