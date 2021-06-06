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
            other.transform.position = beginWall.transform.position - beginWall.GetComponent<BeginWall>()._spawnPointOffset;
        }
        else
        {
            if (other.GetComponent<Debris>() || other.GetComponent<DebrisControlTrigger>())
            {
                Destroy(other.gameObject, 5);
            }
            other.transform.position = beginWall.transform.position - beginWall.GetComponent<BeginWall>()._spawnPointOffset;
        }
    }
    
    public void UnpauseDebrisSpawn()
    {
        debrisSpawnManager_SO.isSpawning = true;
        debrisSpawnManager_SO.isPaused = false;
    }
}
