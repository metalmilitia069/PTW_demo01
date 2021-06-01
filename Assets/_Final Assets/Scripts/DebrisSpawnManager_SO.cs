using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DebrisSpawnManager", menuName = "Managers/DebrisSpawnManager")]
public class DebrisSpawnManager_SO : ScriptableObject
{
    public DebrisConfig[] debrisConfig;
    
    public bool isPaused = true;
    public bool isSpawning = false;
}

[System.Serializable]
public struct DebrisConfig
{
    //public bool isRandomSpawn;
    public int numberOfSections;
    public bool isRandomSpawn;
    public GameObject[] debrisTypes;
}
