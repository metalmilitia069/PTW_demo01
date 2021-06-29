using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseSpawner : MonoBehaviour
{
    public SpawnManager_SO spawnManager_so;
    [SerializeField]
    private float _speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, (_speed * Time.deltaTime * -1));
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<BeginWall>())
        {
            spawnManager_so.CheckWave();
        }
    }
}
