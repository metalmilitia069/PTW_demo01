using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisControlTrigger : MonoBehaviour
{
    [SerializeField]
    private float _speed = 15;

    public SpawnManager_SO spawnManager_SO;
    public DebrisSpawnManager_SO debrisSpawnManager_SO;
    public DebrisTypeSpawnManager_SO debrisTypeSpawnManager_SO;

    public SelectDebris selectDebris;

    public enum DebrisController
    {
        allDebris,
        typeDebris,
        debris,
        noDebris
    }

    public DebrisController chooseDebris;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.GetComponent<BeginWall>())
        {
            other.GetComponent<BeginWall>().endWall.GetComponent<EndWall>().KillMode = true;
            other.GetComponent<BeginWall>().endWall.GetComponent<EndWall>().selectDebris.debrisType = this.selectDebris.debrisType;
        }
        else if (other.GetComponent<EndWall>())
        {
            other.GetComponent<EndWall>().KillMode = false;
            other.GetComponent<EndWall>().selectDebris.debrisType = SelectDebris.DebrisType.standard;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BeginWall>())
        {
            if (chooseDebris == DebrisController.allDebris)
            {
                debrisSpawnManager_SO.isPaused = false;
                debrisTypeSpawnManager_SO.UnpauseDebrisTypeSpawn();
            }
            else if (chooseDebris == DebrisController.typeDebris)
            {
                debrisTypeSpawnManager_SO.UnpauseDebrisTypeSpawn();
            }
            else if (chooseDebris == DebrisController.debris)
            {
                debrisSpawnManager_SO.isPaused = false;
            }
            spawnManager_SO.isPaused = false;
        }
    }

    public void Move()
    {
        this.transform.position += new Vector3(0, 0, (_speed * Time.deltaTime * -1));
    }
}
