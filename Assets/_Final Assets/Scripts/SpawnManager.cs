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
    private Vector3 _spawnPlace;
    public GameObject[] TopViewSpawnPoints;
    public GameObject[] SideViewSpawnPoints;
    public GameObject[] BackViewSpawnPoints;
    

    void Start()
    {
        if (spawnManager_so != null)
        {
            numberOfWaves = spawnManager_so.waveConfig.Length;
        }
    }

    
    void Update()
    {
        if (spawnManager_so != null)
        {
            if (spawnManager_so.isPaused == false)
            {
                SpawnEnemies3();
                spawnManager_so.isPaused = true;
            }
        }
    }

    //public IEnumerator SpawnEnemies()
    //{
    //    for (int i = 0; i < spawnManager_so.waveConfig[_waveIndex].numberOfEnemiesByType[_spawnIndex]; i++)
    //    {
    //        spawnManager_so._currentEnemiesList.Add(Instantiate(spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes[_spawnIndex], new Vector3(0, 0, 0), Quaternion.identity));

    //    }

    //    _spawnIndex++;

    //    if (_spawnIndex > spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes.Length - 1)
    //    {

    //        _spawnIndex = 0;

    //        _waveIndex++;

    //        if (_waveIndex > spawnManager_so.waveConfig.Length - 1) //or its the spawn process is paused TODO
    //        {
    //            StopCoroutine(SpawnEnemies());
    //        }
    //        else
    //        {
    //            yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeToTheNextWave);
    //        }
    //    }
    //    else
    //    {
    //        //Instead of setting the pre-determined time to start spawnning the next type of enemies, the next set should be spawned after all 
    //        //enemies from the last spawn being destroyed
    //        yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeBetweenSpawns);
    //    }
    //}

    //public IEnumerator SpawnEnemies2()
    //{
    //    for (int i = 0; i < spawnManager_so.waveConfig[_waveIndex].numberOfEnemiesByType[_spawnIndex]; i++)
    //    {
    //        spawnManager_so._currentEnemiesList.Add(Instantiate(spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes[_spawnIndex], new Vector3(0, 0, 0), Quaternion.identity));

    //    }

    //    _spawnIndex++;

    //    if (_spawnIndex > spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes.Length - 1)
    //    {

    //        _spawnIndex = 0;

    //        _waveIndex++;

    //        if (_waveIndex > spawnManager_so.waveConfig.Length - 1) //or its the spawn process is paused TODO
    //        {
    //            StopCoroutine(SpawnEnemies2());
    //        }
    //        else
    //        {
    //            yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeToTheNextWave);
    //        }
    //    }
    //    //else
    //    //{
    //    //    //Instead of setting the pre-determined time to start spawnning the next type of enemies, the next set should be spawned after all 
    //    //    //enemies from the last spawn being destroyed
    //    //    yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeBetweenSpawns);
    //    //}
    //}

    public void SpawnEnemies3()
    {
        if (_waveIndex > spawnManager_so.waveConfig.Length - 1)
        {
            //TODO END OF STAGE
            return;
        }        

        for (int i = 0; i < spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes.Length; i++)
        {
            for (int j = 0; j < spawnManager_so.waveConfig[_waveIndex].numberOfEnemiesByType[_spawnIndex]; j++)
            {
                spawnManager_so._currentEnemiesList.Add(Instantiate(spawnManager_so.waveConfig[_waveIndex].waveEnemyTypes[_spawnIndex], RandomSpawnLocation(), Quaternion.identity));
            }
            _spawnIndex++;
        }

        _waveIndex++;
        _spawnIndex = 0;
    }

    public Vector3 RandomSpawnLocation()
    {
        switch (spawnManager_so.waveConfig[_waveIndex].viewToSpawn)
        {
            //-1 = TopView , 0 = SideView, 1 = BackView
            case -1:
                _spawnPlace = new Vector3(Random.Range(TopViewSpawnPoints[0].transform.position.x, TopViewSpawnPoints[1].transform.position.x), 0, TopViewSpawnPoints[0].transform.position.z);
                break;
            case 0:
                _spawnPlace = new Vector3(0, Random.Range(SideViewSpawnPoints[0].transform.position.y, SideViewSpawnPoints[1].transform.position.y), SideViewSpawnPoints[0].transform.position.z);
                break;
            case 1:
                _spawnPlace = new Vector3(Random.Range(BackViewSpawnPoints[0].transform.position.x, BackViewSpawnPoints[1].transform.position.x),
                Random.Range(BackViewSpawnPoints[2].transform.position.y, BackViewSpawnPoints[3].transform.position.y), BackViewSpawnPoints[0].transform.position.z);
                break;
            default:
                _spawnPlace = new Vector3(0, 0, 0);
                Debug.Log("place to spawn was not defined!!!!!!");
                break;
        }

        return _spawnPlace;
    }

    //public void CheckWave()
    //{
    //    if (spawnManager_so._currentEnemiesList.Count == 0)
    //    {
    //        SpawnEnemies3();
    //    }
    //}



    //public IEnumerator TimeBetweenSpawns()
    //{
    //    yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeBetweenSpawns);
    //    _spawnIndex++; 
    //}

    public IEnumerator TimeToTheNextWave()
    {
        yield return new WaitForSeconds(spawnManager_so.waveConfig[_waveIndex].timeToTheNextWave);
    }

    

    
}

//[System.Serializable]
//public struct WaveConfig
//{
//    public bool isRandomSpawn;
//    public float timeToTheNextWave;  ---------
//    public float timeBetweenSpawns;
//    public int numberOfSpawns;
//    public int[] numberOfSimultaneousSpawns;
//    public int[] numberOfEnemiesByType;   ----------
//    public GameObject[] waveEnemyTypes;   ----------
//}
