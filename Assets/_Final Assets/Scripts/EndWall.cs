using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWall : MonoBehaviour
{
    public DebrisSpawnManager_SO debrisSpawnManager_SO;
    public DebrisTypeSpawnManager_SO debrisTypeSpawnManager_SO;

    [SerializeField]
    private GameObject beginWall;
    [SerializeField]
    private bool _killMode;

    public bool KillMode { get => _killMode; set => _killMode = value; }

    public SelectDebris selectDebris;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_killMode)
        {
            if (!debrisTypeSpawnManager_SO.doKillCorroutine)
            {
                if (other.GetComponent<Debris>().selectDebris.debrisType != SelectDebris.DebrisType.standard)
                {                    
                    debrisTypeSpawnManager_SO.doKillCorroutine = true;
                }
            }
            
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, beginWall.transform.position.z - beginWall.GetComponent<BeginWall>()._spawnPointOffset.z);
        }
        else
        {
            if (other.GetComponent<Debris>())
            {
                if (selectDebris.debrisType == other.GetComponent<Debris>().selectDebris.debrisType || other.GetComponent<Debris>().selectDebris.debrisType == SelectDebris.DebrisType.standard)
                {
                    Destroy(other.gameObject, 5);
                }
            }
            else if (other.GetComponent<DebrisControlTrigger>())
            {
                Destroy(other.gameObject, 5);
            }
            else
            {
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, beginWall.transform.position.z - beginWall.GetComponent<BeginWall>()._spawnPointOffset.z);
            }

            //switch (other.GetComponent<Debris>().debrisType)
            //{
            //    case Debris.DebrisType.scenary:
            //        Destroy(other.gameObject, 5);
            //        break;
            //    case Debris.DebrisType.asteroid:
            //        Destroy(other.gameObject, 5);
            //        break;
            //    case Debris.DebrisType.metalSmal:
            //        Destroy(other.gameObject, 5);
            //        break;
            //    default:
            //        break;
            //}

        }
    }
    
    public void UnpauseDebrisSpawn()
    {
        debrisSpawnManager_SO.isSpawning = true;
        debrisSpawnManager_SO.isPaused = false;
    }
}
