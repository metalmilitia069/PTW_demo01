using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisTypeSpawnManager : MonoBehaviour
{
    public DebrisTypeSpawnManager_SO debrisTypeSpawnManager_SO;

    [SerializeField]
    private GameObject[] TopViewSpawnPoints;
    [SerializeField]
    private GameObject[] SideViewSpawnPoints;
    [SerializeField]
    private GameObject[] BackViewSpawnPoints;

    //private int _index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!debrisTypeSpawnManager_SO.isPaused)
        {
            switch (debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].viewToSpawn)
            {
                case 0:
                    StartCoroutine(SpawnTopViewDebrisType());
                    //debrisTypeSpawnManager_SO.isPaused = true;
                    break;
                case 1:
                    StartCoroutine(SpawnSideViewDebrisType());
                    break;
                case 2:
                    StartCoroutine(SpawnBackViewDebrisType());
                    break;
                default:
                    break;
            }

            debrisTypeSpawnManager_SO.PauseDebrisTypeSpawn();
        }
    }

    public IEnumerator SpawnTopViewDebrisType()
    {

        float aboveXCoords = Random.Range(TopViewSpawnPoints[0].transform.position.x, TopViewSpawnPoints[1].transform.position.x);
        float aboveYCoords = Random.Range(TopViewSpawnPoints[0].transform.position.y, TopViewSpawnPoints[2].transform.position.y);

        float belowXCoords = Random.Range(TopViewSpawnPoints[3].transform.position.x, TopViewSpawnPoints[4].transform.position.x);
        float belowYCoords = Random.Range(TopViewSpawnPoints[3].transform.position.x, TopViewSpawnPoints[5].transform.position.x);

        int aboveRandomPrefabIndex = Random.Range(0, debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs.Length);
        
        int belowRandomPrefabIndex = Random.Range(0, debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs.Length);

        Instantiate(debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs[aboveRandomPrefabIndex], 
            new Vector3(aboveXCoords, aboveYCoords, TopViewSpawnPoints[0].transform.position.z), Quaternion.identity);

        Instantiate(debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs[belowRandomPrefabIndex],
            new Vector3(belowXCoords, belowYCoords, TopViewSpawnPoints[3].transform.position.z), Quaternion.identity);

        yield return new WaitForSeconds(0.1f);
    }

    public IEnumerator SpawnSideViewDebrisType()
    {

        float backXCoords = Random.Range(SideViewSpawnPoints[0].transform.position.x, SideViewSpawnPoints[1].transform.position.x);
        float backYCoords = Random.Range(SideViewSpawnPoints[0].transform.position.y, SideViewSpawnPoints[2].transform.position.y);

        float frontXCoords = Random.Range(SideViewSpawnPoints[3].transform.position.x, SideViewSpawnPoints[4].transform.position.x);
        float frontYCoords = Random.Range(SideViewSpawnPoints[3].transform.position.x, SideViewSpawnPoints[5].transform.position.x);

        int backRandomPrefabIndex = Random.Range(0, debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs.Length);

        int frontRandomPrefabIndex = Random.Range(0, debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs.Length);

        Instantiate(debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs[backRandomPrefabIndex],
            new Vector3(backXCoords, backYCoords, TopViewSpawnPoints[0].transform.position.z), Quaternion.identity);

        Instantiate(debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs[frontRandomPrefabIndex],
            new Vector3(frontXCoords, frontYCoords, TopViewSpawnPoints[3].transform.position.z), Quaternion.identity);

        yield return new WaitForSeconds(0.1f);
    }

    public IEnumerator SpawnBackViewDebrisType()
    {

        float aboveXCoords = Random.Range(BackViewSpawnPoints[0].transform.position.x, BackViewSpawnPoints[1].transform.position.x);
        float aboveYCoords = Random.Range(BackViewSpawnPoints[0].transform.position.y, BackViewSpawnPoints[2].transform.position.y);

        float belowXCoords = Random.Range(BackViewSpawnPoints[3].transform.position.x, BackViewSpawnPoints[4].transform.position.x);
        float belowYCoords = Random.Range(BackViewSpawnPoints[3].transform.position.x, BackViewSpawnPoints[5].transform.position.x);

        int aboveRandomPrefabIndex = Random.Range(0, debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs.Length);

        int belowRandomPrefabIndex = Random.Range(0, debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs.Length);

        Instantiate(debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs[aboveRandomPrefabIndex],
            new Vector3(aboveXCoords, aboveYCoords, TopViewSpawnPoints[0].transform.position.z), Quaternion.identity);

        Instantiate(debrisTypeSpawnManager_SO.debrisTypePrefabs[debrisTypeSpawnManager_SO.waveIndex].debrisTypesPrefabs[belowRandomPrefabIndex],
            new Vector3(belowXCoords, belowYCoords, TopViewSpawnPoints[3].transform.position.z), Quaternion.identity);

        yield return new WaitForSeconds(0.1f);
    }

}
