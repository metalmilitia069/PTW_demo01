using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DebrisSpawnManager", menuName = "Managers/DebrisSpawnManager")]
public class DebrisSpawnManager_SO : ScriptableObject
{
    public DebrisConfig[] debrisConfig;
}

[System.Serializable]
public struct DebrisConfig
{
    //public bool isRandomSpawn;
    [Header("View To Spawn Setup: -1 = TopView, 0 = SideView, 1 = BackView")]
    [Range(-1, 2)] // -1 = TopView , 0 = SideView, 1 = BackView, 2 = Triggers
    public int viewToSpawn;

    //public float timeToTheNextWave;
    public float timeBetweenSpawns;
    //public int numberOfSpawns;
    //public int[] numberOfSimultaneousSpawns;
    
    public GameObject[] debrisTypes;
}
