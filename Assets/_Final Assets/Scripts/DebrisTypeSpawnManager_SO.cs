using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "DebrisTypeSpawnManager", menuName = "Managers/DebrisTypeSpawnManager")]
public class DebrisTypeSpawnManager_SO : ScriptableObject
{
    public bool isPaused = true;
    public int waveIndex = 0;

    public DebrisTypesPrefabs[] debrisTypePrefabs;

    private void OnDisable()
    {
        waveIndex = 0;
        isPaused = true;
    }

    public void PauseDebrisTypeSpawn()
    {
        isPaused = true;
        waveIndex++;
    }

    public void UnpauseDebrisTypeSpawn()
    {
        isPaused = false;
    }
}

[System.Serializable]
public struct DebrisTypesPrefabs
{
    
    [Header("Choose the View to Spawn; 0 = TopView, 1 = SideView, 2 = BackView")]
    [Range(0, 2)]
    public int viewToSpawn;
    public GameObject[] debrisTypesPrefabs;
}
