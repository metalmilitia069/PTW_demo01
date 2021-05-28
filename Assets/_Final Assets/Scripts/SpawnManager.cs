using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //public WaveConfig[] waves = new WaveConfig[1];
    public SpawnManager_SO spawnManager_so;

    public int numberOfWaves;
    private int _waveIndex = 0;
    private int _spawnIndex = 0;
    
    void Start()
    {
        numberOfWaves = spawnManager_so.waveConfig.Length;
    }

    
    void Update()
    {
        if (spawnManager_so._currentEnemiesList.Count == 0)
        {
            SpawnEnemies();
        }
    }

    public void SpawnEnemies()
    {
        if (_spawnIndex > spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes.Length -1)
        {
            _spawnIndex = 0;
            _waveIndex++;
            if (_waveIndex > spawnManager_so.waveConfig.Length -1) //or its the spawn process is paused TODO
            {
                return;
            }            
        }

        for (int i = 0; i < spawnManager_so.waveConfig[_waveIndex].numberOfEnemiesByType[_spawnIndex]; i++)
        {
            spawnManager_so._currentEnemiesList.Add(Instantiate(spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes[_spawnIndex], new Vector3(0, 0, 0), Quaternion.identity));

        }

        _spawnIndex++;
    }

    public IEnumerable TimeBetweenSpawns()
    {
        yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeBetweenSpawns);
        _spawnIndex++; 
    }

    public IEnumerable TimeToTheNextWave()
    {
        yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeToTheNextWave);
    }

    

    
}

//[System.Serializable]
//public struct WaveConfig
//{
//    public bool isRandomSpawn;
//    public float timeToTheNextWave;
//    public float timeBetweenSpawns;
//    public int numberOfSpawns;
//    public int[] numberOfSimultaneousSpawns;
//    public int[] numberOfEnemiesByType;
//    public GameObject[] waveEnemyTypes;
//}
