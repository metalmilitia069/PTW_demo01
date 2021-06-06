using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DebrisTypeSpawnManager", menuName = "Managers/DebrisTypeSpawnManager")]
public class DebrisTypeSpawnManager_SO : ScriptableObject
{
    public bool isPaused = true;
    //public int number

    public DebrisTypesPrefabs[] debrisTypePrefabs;
}

[System.Serializable]
public struct DebrisTypesPrefabs
{
    
    [Header("Choose the View to Spawn; 0 = TopView, 1 = SideView, 2 = BackView")]
    [Range(0, 2)]
    public int ViewToSpawn;
    public GameObject[] debrisTypesPrefabs;
}
