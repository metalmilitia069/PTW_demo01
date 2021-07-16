using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField]
    private float _speed = 15.0f;

    private int _projectileHealth = 2;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.GetComponent<ProjectileBase>())
        {
            TakeDamage();
            other.GetComponent<ProjectileBase>().KillProjectile();
        }
        else if (other.GetComponent<ShipStats>())
        {
            other.GetComponent<ShipStats>().visualEffectPrefab.transform.position = this.transform.position;
            other.GetComponent<ShipStats>().visualEffectPrefab.GetComponentInChildren<VisualEffect>().initialEventName = "Custom";
            other.GetComponent<ShipStats>().visualEffectPrefab.GetComponentInChildren<VisualEffect>().Reinit();
            other.GetComponent<ShipStats>().TakeDamage();
            KillProjectile();
        }
    }

    public void Move()
    {
        this.transform.position += this.transform.forward * _speed * Time.deltaTime;
    }

    private void TakeDamage()
    {
        if (_projectileHealth <= 0)
        {
            KillProjectile();
        }
        else
        {
            _projectileHealth--;
        }
    }

    private void KillProjectile()
    {
        Destroy(this.gameObject);
    }

}
