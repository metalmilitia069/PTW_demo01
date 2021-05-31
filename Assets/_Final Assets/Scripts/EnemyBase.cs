using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public SpawnManager_SO spawnManager_so;
    
    [SerializeField]
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {

        this.transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
    }

    public void TakeDamage()
    {
        //health--
        //check if the enemy died
        //if dead, then

    }

    public void EnemyDied()
    {
        if (spawnManager_so != null)
        {
            spawnManager_so._currentEnemiesList.Remove(this.gameObject);
            
        }
        Destroy(this.gameObject);
    }
}
