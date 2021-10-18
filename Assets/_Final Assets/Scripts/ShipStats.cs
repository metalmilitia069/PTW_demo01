using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : ShipBase
{
    [Header("Player Stats:")]
    public ShipStats_SO shipStats_SO;
    public UIManager_SO uIManager_SO;
    public CutSceneManager_SO cutSceneManager_SO;

    public GameObject visualEffectPrefab;

    public GameObject[] shieldPrefabs;

    public bool isShipFrozen = false;

    [Header("For CutScenes")]
    public GameObject playerSceneActor;
    public GameObject playerSmokeVFX;

    [Header("Debugger - Unplug Later")]
    public bool isGodModeOn = false;

    // Start is called before the first frame update
    private void Awake()
    {
        _speed = shipStats_SO.playerSpeed;
        _fireRate = shipStats_SO.fireRate;

        _playerControls = new PlayerControls();
        gameManager_SO.shipStats = this;

        //if (cutSceneManager_SO != null)
        //{
            cutSceneManager_SO.shipStatsRef = this;
        //}

        foreach (var item in visualEffects)
        {
            item.initialEventName = "Custom";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShipFrozen)
        {
            Movement();
            Shooting();
        }
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    public void CheckShipDamage()
    {
        if (shipStats_SO.playerHealth <= 2)
        {
            playerSmokeVFX.gameObject.SetActive(true);
        }
        else
        {
            playerSmokeVFX.gameObject.SetActive(false);
        }
    }

    public void TakeDamage()
    {
        if (isGodModeOn)
        {
            return;
        }
        
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
                CheckShipDamage();
            }
        }
        else
        {
            shipStats_SO.playerShield--;
            SwitchShield();
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

    public void KillShip()
    {
        shipStats_SO.playerHealth = 0;
        shipStats_SO.playerShield = 0;
        uIManager_SO.canUpdadeHUD = true;
        IsPlayerDead();
    }

    public void LevelUp()
    {
        if (shipStats_SO.playerLevel >= shipStats_SO.maxLevel)
        {
            return;
        }

        shipStats_SO.playerLevel++;
        shipStats_SO.playerMaxHealth = shipStats_SO.playerLevel + 2;
        shipStats_SO.playerHealth = shipStats_SO.playerMaxHealth;

        shipStats_SO.playerMaxShield = shipStats_SO.playerLevel + 2;
        shipStats_SO.playerShield = shipStats_SO.playerMaxShield;

        SwitchShield();

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

        if (shipStats_SO.playerLevel == shipStats_SO.maxLevel)
        {
            shipStats_SO.levelProgressionRate = 1;
            uIManager_SO.canUpdadeLvl = true;
            uIManager_SO.canUpdadeHUD = true;
            return;
        }

        shipStats_SO.levelProgressionRate = ((shipStats_SO.levelingUpXp * 1.0f) / shipStats_SO.levelUpThreshold);

        uIManager_SO.canUpdadeHUD = true;

        if (shipStats_SO.levelProgressionRate >= 1 && shipStats_SO.playerLevel <= shipStats_SO.maxLevel)
        {
            LevelUp();
        }

    }

    public void AddXpToAmmunition(int AmmunitionXP)
    {
        //AmmunitionType ammunitionType = AmmunitionType.singleShotLvl01;
        switch (ammunitionType)
        {
            case AmmunitionType.singleShotLvl01:
                shipStats_SO.singleShotCurrentXP += AmmunitionXP;
                shipStats_SO.singleShotProgressionRate = (shipStats_SO.singleShotCurrentXP * 1.0f) / shipStats_SO.singleShotLevelUpThreshold;
                if (shipStats_SO.singleShotProgressionRate >= 1.0f)
                {
                    LevelUpSingleShot();
                }
                break;
            case AmmunitionType.tripleShotLvl01:
                shipStats_SO.tripleShotCurrentXP += AmmunitionXP;
                shipStats_SO.tripleShotProgressionRate = (shipStats_SO.tripleShotCurrentXP * 1.0f) / shipStats_SO.tripleShotLevelUpThreshold;
                if (shipStats_SO.tripleShotProgressionRate >= 1.0f)
                {
                    LevelUpTripleShot();
                }
                break;
            case AmmunitionType.diagonalShotLvl01:
                break;
            case AmmunitionType.singleShotLvl02:

                break;
            case AmmunitionType.tripleShotLvl02:
                break;
            case AmmunitionType.diagonalShotLvl02:
                break;
            case AmmunitionType.singleShotLvl03:
                return;                
            case AmmunitionType.tripleShotLvl03:
                return;                
            case AmmunitionType.diagonalShotLvl03:
                return;
                
            default:
                break;
        }
    }

    public void LevelUpSingleShot()
    {
        if (shipStats_SO.singleShotLevel == 1)
        {
            shipStats_SO.singleShotLevel = 2;
            shipStats_SO.singleShotLevelUpThreshold += (shipStats_SO.singleShotLevelUpThreshold * 2.0f);
            shipStats_SO.singleShotProgressionRate = 0.0f;
            ammunitionType = AmmunitionType.singleShotLvl02;
            return;
        }

        if (shipStats_SO.singleShotLevel == 2)
        {
            shipStats_SO.singleShotLevel = 3;
            shipStats_SO.singleShotLevelUpThreshold += (shipStats_SO.singleShotLevelUpThreshold * 2.0f);
            shipStats_SO.singleShotProgressionRate = 0.0f;
            ammunitionType = AmmunitionType.singleShotLvl03;            
        }
    }

    public void LevelUpTripleShot()
    {

    }

    public void LevelUpDiagonalShot()
    {

    }



    public void SwitchShield()
    {
        if (this.shipStats_SO.playerShield <= 0)
        {
            foreach (var shield in shieldPrefabs)
            {
                shield.gameObject.SetActive(false);
            }
            return;
        }

        float shieldRate = this.shipStats_SO.playerShield / this.shipStats_SO.playerMaxShield;

        TurnOffShields();

        if (shieldRate >= 0.75)
        {            
            shieldPrefabs[0].SetActive(true);
            return;
        }
        else if (shieldRate >= 0.25f && shieldRate <= 0.75f)
        {
            shieldPrefabs[1].SetActive(true);
            return;
        }
        else
        {
            shieldPrefabs[2].SetActive(true);
        }
    }

    public void TurnOffShields()
    {
        for (int i = 0; i < shieldPrefabs.Length - 1; i++)
        {
            shieldPrefabs[i].SetActive(false);
        }
    }
}
