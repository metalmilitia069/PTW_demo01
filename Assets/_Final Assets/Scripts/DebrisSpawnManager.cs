using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisSpawnManager : MonoBehaviour
{
    public DebrisSpawnManager_SO debrisSpawnManager_SO;

    [SerializeField]
    private GameObject _beginWall;
    [SerializeField]
    private Vector3 _spawnPointOffset = new Vector3(0, 0, 50);

    private int _debrisIndex = 0;
    private int _sectionsNumber = 0;    

    // Update is called once per frame
    void Update()
    {
        if (!debrisSpawnManager_SO.isPaused)
        {
            DebrisSpawn1();
            debrisSpawnManager_SO.isPaused = true;
        }
    }
    
    public void DebrisSpawn1()
    {
        if (_debrisIndex > debrisSpawnManager_SO.debrisConfig.Length - 1)
        {
            return;
        }

        if (debrisSpawnManager_SO.debrisConfig[_debrisIndex].isRandomSpawn)
        {
            int randomDebris = 0;

            randomDebris = Random.Range(0, debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes.Length + 1);

            Instantiate(debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes[randomDebris], _beginWall.transform.position, Quaternion.identity);            
        }
        else
        {
            Instantiate(debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes[_sectionsNumber], _beginWall.transform.position, Quaternion.identity);            
        }
               
        _sectionsNumber++;

        if (_sectionsNumber >= debrisSpawnManager_SO.debrisConfig[_debrisIndex].numberOfSections)
        {
            _sectionsNumber = 0;
            _debrisIndex++;
        }
    }

    //public void DebrisSpawn()
    //{
    //    if (_debrisIndex > debrisSpawnManager_SO.debrisConfig.Length -1)
    //    {
    //        return;
    //    }

    //    if (debrisSpawnManager_SO.debrisConfig[_debrisIndex].isRandomSpawn)
    //    {
    //        int randomDebris = 0;

    //        for (int i = 0; i < debrisSpawnManager_SO.debrisConfig[_debrisIndex].numberOfSections; i++)
    //        {
    //            randomDebris = Random.Range(0, debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes.Length + 1);

    //            Instantiate(debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes[randomDebris], _beginWall.transform.position, Quaternion.identity);
    //        }
    //    }
    //    else
    //    {
    //        for (int i = 0; i < debrisSpawnManager_SO.debrisConfig[_debrisIndex].numberOfSections; i++)
    //        {
    //            Instantiate(debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes[i], _beginWall.transform.position, Quaternion.identity);
    //        }
    //    }

    //    _debrisIndex++;
    //}

    


}
