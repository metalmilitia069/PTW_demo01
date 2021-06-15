using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : EnemyStats
{
    [Header("Combat")]
    [SerializeField]
    protected GameObject[] firePoints;

    protected float timeToShoot = 0;


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

    private void OnTriggerStay(Collider other)
    {
        if (!other.GetComponent<ProjectileBase>())
        {
            float getAway = (this.transform.position.x - other.transform.position.x);

            if (getAway > 0)
            {
                this.transform.position += new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
            }
            else if (getAway < 0)
            {
                this.transform.position -= new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
            }
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
        for (int i = 0; i < firePoints.Length; i++)
        {
            Quaternion rotation = firePoints[i].transform.localRotation;
            Instantiate(projectile, firePoints[i].transform.position, rotation);
        }
    }

    
}
