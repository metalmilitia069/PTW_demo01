using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnManagerPoll", menuName = "Managers/Spawner")]
public class SpawnManager_SO : ScriptableObject
{
    [Header("something")]
    public int number;

    public List<GameObject> _currentEnemiesList = new List<GameObject>();


    private void OnDisable()
    {
        _currentEnemiesList = new List<GameObject>();
    }
    
    public WaveConfig[] waveConfig;
}

[System.Serializable]
public struct WaveConfig
{
    //public bool isRandomSpawn;
    public float timeToTheNextWave;
    //public float timeBetweenSpawns;
    //public int numberOfSpawns;
    //public int[] numberOfSimultaneousSpawns;
    public int[] numberOfEnemiesByType;
    public GameObject[] waveEnemyTypes;
}


