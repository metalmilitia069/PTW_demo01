using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginWall : MonoBehaviour
{
    public DebrisSpawnManager_SO debrisSpawnManager_SO;

    
    public EndWall endWall;
    public Vector3 _spawnPointOffset = new Vector3(0, 0, 75);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Debris>() && debrisSpawnManager_SO.isSpawning)
        {
            debrisSpawnManager_SO.isPaused = false;
        }
    }
}
