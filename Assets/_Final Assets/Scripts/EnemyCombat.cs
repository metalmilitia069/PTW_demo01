using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : EnemyStats
{
    public GameManager_SO gameManager_SO;

    [Header("Combat")]
    [SerializeField]
    protected GameObject[] firePoints;

    protected float timeToShoot = 0;

    public GameObject visualEffectPrefab;

    //For shielded ships only
    public GameObject[] shieldPrefabs;


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
            other.GetComponent<ProjectileBase>().KillProjectile();
        }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (!other.GetComponent<ProjectileBase>())
    //    {
    //        float getAway = (this.transform.position.x - other.transform.position.x);

    //        if (getAway > 0)
    //        {
    //            this.transform.position += new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
    //        }
    //        else if (getAway < 0)
    //        {
    //            this.transform.position -= new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
    //        }
    //    }
    //}

    public void TakeDamage()
    {
        if (shields <= 0)
        {
            health--;

            if (health <= 0)
            {
                EnemyDied();
            }
        }
        else
        {
            shields--;
            SwitchShield();            
        }
    }

    public void EnemyDied()
    {
        gameManager_SO.shipStats.AddXp(pointsWorth);
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
            Quaternion rotation = firePoints[i].transform.rotation;
            Instantiate(projectile, firePoints[i].transform.position, rotation);
        }
    }

    public void SwitchShield()
    {
        if (shields <= 0)
        {
            foreach (var shield in shieldPrefabs)
            {
                shield.gameObject.SetActive(false);
            }
            return;
        }

        float shieldRate = (float)shields / shieldMax;

        TurnOffShields();

        if (shieldRate >= 0.75)
        {
            shieldPrefabs[0].SetActive(true);
            return;
        }
        else if (shieldRate >= 0.25f && shieldRate <= 0.75f)
        {
            shieldPrefabs[1].SetActive(true);
            return;
        }
        else
        {
            shieldPrefabs[2].SetActive(true);
        }
    }

    public void TurnOffShields()
    {
        for (int i = 0; i < shieldPrefabs.Length - 1; i++)
        {
            shieldPrefabs[i].SetActive(false);
        }
    }


}
