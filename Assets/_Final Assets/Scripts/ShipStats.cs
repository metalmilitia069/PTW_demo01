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
        gameManager_SO.shipBase = this;
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
}
