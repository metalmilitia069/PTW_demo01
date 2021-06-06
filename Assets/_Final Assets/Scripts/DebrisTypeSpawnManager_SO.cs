using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DebrisTypeSpawnManager", menuName = "Managers/DebrisTypeSpawnManager")]
public class DebrisTypeSpawnManager_SO : ScriptableObject
{
    public bool isPaused = true;
    //public int number

    public GameObject[] DebrisTypePrefabs;
}
