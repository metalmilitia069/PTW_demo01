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

    public List<AmmunitionType> ammunitionsList;

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

        //ammunitionsList.Add(AmmunitionType.singleShotLvl01);
        //ammunitionsList.Add(AmmunitionType.tripleShotLvl01);
        //ammunitionType = ammunitionsList[0];
        UpdateAmmunitionList(shipStats_SO.playerLevel);
        //ammunitionType = ammunitionsList[0];
        Debug.Log("ammunition type = " + ammunitionType.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        if (!isShipFrozen)
        {
            Movement();
            Shooting();
            SwitchAmmo();
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
                AddXPToSingleShot(AmmunitionXP);
                return;
            case AmmunitionType.tripleShotLvl01:
                AddXPToTripleShot(AmmunitionXP);
                return;
            case AmmunitionType.diagonalShotLvl01:
                AddXPToDiagonalShot(AmmunitionXP);
                return;
            case AmmunitionType.singleShotLvl02:
                AddXPToSingleShot(AmmunitionXP);
                return;
            case AmmunitionType.tripleShotLvl02:
                AddXPToTripleShot(AmmunitionXP);
                return;
            case AmmunitionType.diagonalShotLvl02:
                AddXPToDiagonalShot(AmmunitionXP);
                return;
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

    public void AddXPToSingleShot(int AmmunitionXP)
    {
        shipStats_SO.singleShotCurrentXP += AmmunitionXP;
        shipStats_SO.singleShotProgressionRate = (shipStats_SO.singleShotCurrentXP * 1.0f) / shipStats_SO.singleShotLevelUpThreshold;
        if (shipStats_SO.singleShotProgressionRate >= 1.0f)
        {
            LevelUpSingleShot();
            uIManager_SO.canUpdadeHUD = true;
        }
        else
        {
            uIManager_SO.canUpdadeHUD = true;
        }
    }

    public void AddXPToTripleShot(int AmmunitionXP)
    {
        shipStats_SO.tripleShotCurrentXP += AmmunitionXP;
        shipStats_SO.tripleShotProgressionRate = (shipStats_SO.tripleShotCurrentXP * 1.0f) / shipStats_SO.tripleShotLevelUpThreshold;
        if (shipStats_SO.tripleShotProgressionRate >= 1.0f)
        {
            LevelUpTripleShot();
            uIManager_SO.canUpdadeHUD = true;
        }
        else
        {
            uIManager_SO.canUpdadeHUD = true;
        }
    }

    public void AddXPToDiagonalShot(int AmmunitionXP)
    {
        shipStats_SO.diagonalShotCurrentXP += AmmunitionXP;
        shipStats_SO.diagonalShotProgressionRate = (shipStats_SO.diagonalShotCurrentXP * 1.0f) / shipStats_SO.diagonalShotLevelUpThreshold;
        if (shipStats_SO.diagonalShotProgressionRate >= 1.0f)
        {
            LevelUpDiagonalShot();
            uIManager_SO.canUpdadeHUD = true;
        }
        else
        {
            uIManager_SO.canUpdadeHUD = true;
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
            //uIManager_SO.canUpdadeHUD = true;
            return;
        }

        if (shipStats_SO.singleShotLevel == 2)
        {
            shipStats_SO.singleShotLevel = 3;            
            shipStats_SO.singleShotProgressionRate = 1.0f;
            ammunitionType = AmmunitionType.singleShotLvl03;            
        }
    }

    public void LevelUpTripleShot()
    {
        if (shipStats_SO.tripleShotLevel == 1)
        {
            shipStats_SO.tripleShotLevel = 2;
            shipStats_SO.tripleShotLevelUpThreshold += (shipStats_SO.tripleShotLevelUpThreshold * 2.0f);
            shipStats_SO.tripleShotProgressionRate = 0.0f;
            ammunitionType = AmmunitionType.tripleShotLvl02;
            return;
        }

        if (shipStats_SO.tripleShotLevel == 2)
        {
            shipStats_SO.tripleShotLevel = 3;            
            shipStats_SO.tripleShotProgressionRate = 1.0f;
            ammunitionType = AmmunitionType.tripleShotLvl03;
        }
    }

    public void LevelUpDiagonalShot()
    {
        if (shipStats_SO.diagonalShotLevel == 1)
        {
            shipStats_SO.diagonalShotLevel = 2;
            shipStats_SO.diagonalShotLevelUpThreshold += (shipStats_SO.diagonalShotLevelUpThreshold * 2.0f);
            shipStats_SO.diagonalShotProgressionRate = 0.0f;
            ammunitionType = AmmunitionType.diagonalShotLvl02;
            return;
        }

        if (shipStats_SO.diagonalShotLevel == 2)
        {
            shipStats_SO.diagonalShotLevel = 3;            
            shipStats_SO.diagonalShotProgressionRate = 1.0f;
            ammunitionType = AmmunitionType.diagonalShotLvl03;
        }
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

    public void UpdateAmmunitionList(int playerLevel)
    {
        bool canUseSingleShot = false;
        bool canUseTripleShot = false;
        bool canUseDiagonalShot = false;

        switch (playerLevel)
        {
            case 1:
                canUseSingleShot = true;
                break;
            case 2:
                canUseSingleShot = true;
                canUseTripleShot = true;
                break;
            case 3:
                canUseSingleShot = true;
                canUseTripleShot = true;
                canUseDiagonalShot = true;
                break;
            default:
                canUseSingleShot = true;
                canUseTripleShot = true;
                canUseDiagonalShot = true;
                break;
        }

        if (canUseSingleShot)
        {
            switch (shipStats_SO.singleShotLevel)
            {
                case 1:
                    ammunitionsList.Add(AmmunitionType.singleShotLvl01);
                    break;
                case 2:
                    ammunitionsList.Remove(AmmunitionType.singleShotLvl01);
                    ammunitionsList.Add(AmmunitionType.singleShotLvl02);
                    break;
                case 3:
                    ammunitionsList.Remove(AmmunitionType.singleShotLvl02);
                    ammunitionsList.Add(AmmunitionType.singleShotLvl03);
                    break;
                default:
                    break;
            }
        }

        if (canUseTripleShot)
        {
            switch (shipStats_SO.tripleShotLevel)
            {
                case 1:
                    ammunitionsList.Add(AmmunitionType.tripleShotLvl01);
                    break;
                case 2:
                    ammunitionsList.Remove(AmmunitionType.tripleShotLvl01);
                    ammunitionsList.Add(AmmunitionType.tripleShotLvl02);
                    break;
                case 3:
                    ammunitionsList.Remove(AmmunitionType.tripleShotLvl02);
                    ammunitionsList.Add(AmmunitionType.tripleShotLvl03);
                    break;
                default:
                    break;
            }
        }

        if (canUseDiagonalShot)
        {
            switch (shipStats_SO.diagonalShotLevel)
            {
                case 1:
                    ammunitionsList.Add(AmmunitionType.diagonalShotLvl01);
                    break;
                case 2:
                    ammunitionsList.Remove(AmmunitionType.diagonalShotLvl01);
                    ammunitionsList.Add(AmmunitionType.diagonalShotLvl02);
                    break;
                case 3:
                    ammunitionsList.Remove(AmmunitionType.diagonalShotLvl02);
                    ammunitionsList.Add(AmmunitionType.diagonalShotLvl03);
                    break;
                default:
                    break;
            }
        }

        ammunitionType = ammunitionsList[0];
        GetAmmunitionNameAndLevel();
    }

    public void SwitchAmmo()
    {
        //_playerMovementY = _playerControls.LocomotionSideView.VerticalMove.ReadValue<float>() * _speed * Time.deltaTime;

        

        if (_playerControls.ChangeAmmo.AmmoChanger.triggered)
        {
            int index = ammunitionsList.IndexOf(ammunitionType);
            index++;

            if (index >= ammunitionsList.Count)
            {
                index = 0;
            }

            ammunitionType = ammunitionsList[index];

            GetAmmunitionNameAndLevel();
        }

    }

    public void GetAmmunitionNameAndLevel()
    {
        switch (ammunitionType)
        {
            case AmmunitionType.singleShotLvl01:
                shipStats_SO.ammunitionName = "Single Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.singleShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.singleShotProgressionRate;
                break;
            case AmmunitionType.tripleShotLvl01:
                shipStats_SO.ammunitionName = "Triple Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.tripleShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.tripleShotProgressionRate;
                break;
            case AmmunitionType.diagonalShotLvl01:
                shipStats_SO.ammunitionName = "Diagonal Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.diagonalShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.diagonalShotProgressionRate;
                break;
            case AmmunitionType.singleShotLvl02:
                shipStats_SO.ammunitionName = "Single Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.singleShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.singleShotProgressionRate;
                break;
            case AmmunitionType.tripleShotLvl02:
                shipStats_SO.ammunitionName = "Triple Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.tripleShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.tripleShotProgressionRate;
                break;
            case AmmunitionType.diagonalShotLvl02:
                shipStats_SO.ammunitionName = "Diagonal Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.diagonalShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.diagonalShotProgressionRate;
                break;
            case AmmunitionType.singleShotLvl03:
                shipStats_SO.ammunitionName = "Single Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.singleShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.singleShotProgressionRate;
                break;
            case AmmunitionType.tripleShotLvl03:
                shipStats_SO.ammunitionName = "Triple Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.tripleShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.tripleShotProgressionRate;
                break;
            case AmmunitionType.diagonalShotLvl03:
                shipStats_SO.ammunitionName = "Diagonal Shot";
                shipStats_SO.ammunitionLevel = shipStats_SO.diagonalShotLevel;
                shipStats_SO.ammunitionProgressionRate = shipStats_SO.diagonalShotProgressionRate;
                break;
            default:
                break;
        }
        uIManager_SO.canUpdadeHUD = true;
    }

    

}
