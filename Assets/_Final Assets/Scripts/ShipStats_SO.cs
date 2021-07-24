using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player/Stats")]
public class ShipStats_SO : ScriptableObject
{
    public float playerMaxHealth = 3;
    public float playerHealth = 0;
    public float playerMaxShield = 3;
    public float playerShield = 0;
    public float playerSpeed = 0;
    public float fireRate = 0;

    [Range(1, 7)]
    public int playerLevel = 1;

    public int maxLevel = 7;
    public int playerXPCumulated = 0;
    public int levelingUpXp = 0;
    public int playerScore = 0;
    
    public float levelUpThreshold = 0;
    public float levelProgressionRate = 0;

    public void ResetPlayerData()
    {
        playerMaxHealth = 3; //TODO 
        playerHealth = 0;
        playerMaxShield = 3;  //TODO
        playerShield = 0;
        playerSpeed = 0;
        fireRate = 0;
    }

}
