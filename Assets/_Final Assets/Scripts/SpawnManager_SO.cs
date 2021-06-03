using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnManagerPoll", menuName = "Managers/Spawner")]
public class SpawnManager_SO : ScriptableObject
{
    [Header("something")]
    public int number;
    public bool isPaused = true;
    public List<GameObject> _currentEnemiesList = new List<GameObject>();

    public void CheckWave()
    {
        if (_currentEnemiesList.Count == 0)
        {
            isPaused = false;
        }
    }


    private void OnDisable()
    {
        isPaused = true;
        _currentEnemiesList = new List<GameObject>();
    }
    
    public WaveConfig[] waveConfig;
}

[System.Serializable]
public struct WaveConfig
{
    //public bool isRandomSpawn;
    [Header("View To Spawn Setup: -1 = TopView, 0 = SideView, 1 = BackView")]
    [Range(-1, 2)] // -1 = TopView , 0 = SideView, 1 = BackView, 2 = Triggers
    public int viewToSpawn;

    //public float timeToTheNextWave;
    public float timeBetweenSpawns;
    //public int numberOfSpawns;
    //public int[] numberOfSimultaneousSpawns;
    public int[] numberOfEnemiesByType;
    public GameObject[] waveEnemyTypes;
    
}


