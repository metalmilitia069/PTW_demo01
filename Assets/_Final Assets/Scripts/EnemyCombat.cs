using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : EnemyStats
{



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
        if (other.GetComponent<ProjectileBase>())
        {
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        //health--
        //check if the enemy died
        //if dead, then

        EnemyDied();

    }

    public void EnemyDied()
    {
        if (spawnManager_so != null)
        {
            spawnManager_so._currentEnemiesList.Remove(this.gameObject);
            spawnManager_so.CheckWave();
        }

        Destroy(this.gameObject);
    }

    public void AttackPlayer()
    {

    }

    
}
