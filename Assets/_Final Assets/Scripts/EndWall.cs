using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWall : MonoBehaviour
{
    public DebrisSpawnManager_SO debrisSpawnManager_SO;

    [SerializeField]
    private GameObject beginWall;
    [SerializeField]
    private bool _killMode;

    public bool KillMode { get => _killMode; set => _killMode = value; }

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
            //other.transform.position = beginWall.transform.position - beginWall.GetComponent<BeginWall>()._spawnPointOffset;
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, beginWall.transform.position.z - beginWall.GetComponent<BeginWall>()._spawnPointOffset.z);
        }
        else
        {
            if (other.GetComponent<Debris>() || other.GetComponent<DebrisControlTrigger>())
            {
                Destroy(other.gameObject, 5);
            }
            else
            {
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, beginWall.transform.position.z - beginWall.GetComponent<BeginWall>()._spawnPointOffset.z);
            }
        }
    }
    
    public void UnpauseDebrisSpawn()
    {
        debrisSpawnManager_SO.isSpawning = true;
        debrisSpawnManager_SO.isPaused = false;
    }
}
