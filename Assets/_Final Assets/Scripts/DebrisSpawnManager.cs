using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisSpawnManager : MonoBehaviour
{
    public DebrisSpawnManager_SO debrisSpawnManager_SO;

    [SerializeField]
    private GameObject _beginWall;
    [SerializeField]
    private GameObject _endWall;

    private int _debrisIndex = 0;
    private int _sectionsNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!debrisSpawnManager_SO.isPaused)
        {
            DebrisSpawn();
        }
    }

    public void DebrisSpawn()
    {
        if (_debrisIndex > debrisSpawnManager_SO.debrisConfig.Length -1)
        {
            return;
        }

        if (debrisSpawnManager_SO.debrisConfig[_debrisIndex].isRandomSpawn)
        {
            int randomDebris = 0;

            for (int i = 0; i < debrisSpawnManager_SO.debrisConfig[_debrisIndex].numberOfSections; i++)
            {
                randomDebris = Random.Range(0, debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes.Length + 1);

                Instantiate(debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes[randomDebris], _beginWall.transform.position, Quaternion.identity);
            }
        }
        else
        {
            for (int i = 0; i < debrisSpawnManager_SO.debrisConfig[_debrisIndex].numberOfSections; i++)
            {
                Instantiate(debrisSpawnManager_SO.debrisConfig[_debrisIndex].debrisTypes[i], _beginWall.transform.position, Quaternion.identity);
            }
        }

        _debrisIndex++;
    }

    


}
