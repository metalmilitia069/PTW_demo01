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

        uIManager_SO.canUpdadeHUD = true;

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
        shipStats_SO.playerShield = shipStats_SO.playerLevel + 2;
        shipStats_SO.levelUpThreshold += (shipStats_SO.levelUpThreshold * 1.0f);
        shipStats_SO.levelingUpXp = 0;

        shipStats_SO.levelProgressionRate = ((shipStats_SO.levelingUpXp * 1.0f) / shipStats_SO.levelUpThreshold);

        uIManager_SO.canUpdadeLvl = true;
        uIManager_SO.canUpdadeHUD = true;
    }

    public void AddXp(int XpToAdd)
    {
        shipStats_SO.playerXPCumulated += XpToAdd;
        shipStats_SO.playerScore += XpToAdd;
        shipStats_SO.levelingUpXp += XpToAdd;


        shipStats_SO.levelProgressionRate = ((shipStats_SO.levelingUpXp * 1.0f) / shipStats_SO.levelUpThreshold);

        uIManager_SO.canUpdadeHUD = true;

        if (shipStats_SO.levelProgressionRate >= 1 && shipStats_SO.playerLevel <= shipStats_SO.maxLevel)
        {
            LevelUp();
        }
    }
}
