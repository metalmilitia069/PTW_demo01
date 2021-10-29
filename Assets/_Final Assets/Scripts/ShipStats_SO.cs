using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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

    [Header("Ammunition Stats")]
    public int shotsMaxLevel = 3;
    [Range(1,3)]
    public int singleShotLevel = 1;
    [Range(1,3)]
    public int tripleShotLevel = 1;
    [Range(1,3)]
    public int diagonalShotLevel = 1;

    public float singleShotLevelUpThreshold = 200;
    public float tripleShotLevelUpThreshold = 200;
    public float diagonalShotLevelUpThreshold = 200;

    public int singleShotCurrentXP = 0;
    public int tripleShotCurrentXP = 0;
    public int diagonalShotCurrentXP = 0;

    public float singleShotProgressionRate = 0;
    public float tripleShotProgressionRate = 0;
    public float diagonalShotProgressionRate = 0;

    public string ammunitionName = "Single Shot";
    public int ammunitionLevel = 0;
    public float ammunitionProgressionRate = 0;
    

    public void ResetPlayerData()
    {
        playerMaxHealth = 3; //TODO 
        playerHealth = 3;
        playerMaxShield = 3;  //TODO
        playerShield = 3;
        playerSpeed = 60;
        fireRate = 0.2f;

        playerLevel = 1;

        singleShotLevel = 1;
        tripleShotLevel = 1;
        diagonalShotLevel = 1;

        playerXPCumulated = 0;
        levelingUpXp = 0;
        playerScore = 0;

        levelUpThreshold = 200;
        levelProgressionRate = 0;

        singleShotLevelUpThreshold = 100;
        tripleShotLevelUpThreshold = 100;
        diagonalShotLevelUpThreshold = 100;

        singleShotCurrentXP = 0;
        tripleShotCurrentXP = 0;
        diagonalShotCurrentXP = 0;

        singleShotProgressionRate = 0;
        tripleShotProgressionRate = 0;
        diagonalShotProgressionRate = 0;
    }



}

#if UNITY_EDITOR
[CustomEditor(typeof(ShipStats_SO))]
class ShipStatsFunctions : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var shipStatsVariables = (ShipStats_SO)target;
        if (shipStatsVariables == null)
        {
            return;
        }

        if (GUILayout.Button("Reset Player Status"))
        {
            shipStatsVariables.ResetPlayerData();
        }
    }
}
#endif
