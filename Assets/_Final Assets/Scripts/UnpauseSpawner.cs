using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseSpawner : MonoBehaviour
{
    public SpawnManager_SO spawnManager_so;
    [SerializeField]
    private float _speed = 30;
    [SerializeField]
    private float _delayingTime = 5.0f;

    private bool _canTrigger = true;
    
    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, (_speed * Time.deltaTime * -1));
    }

    private void OnTriggerExit(Collider other)
    {        
        if (other.GetComponent<BeginWall>())
        {            
            StartCoroutine(UnpauseSpawnManagerCorroutine());
        }        
    }

    public IEnumerator UnpauseSpawnManagerCorroutine()
    {
        yield return new WaitForSeconds(_delayingTime);
        spawnManager_so.isPaused = false;
        yield return new WaitForSeconds(0.5f);
        StopCoroutine(UnpauseSpawnManagerCorroutine());
        Destroy(this.gameObject);
    }
}
