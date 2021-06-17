using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Debug.Log("Hitting");
        if (other.GetComponent<ProjectileBase>())
        {
            TakeDamage();
        }
        else if (other.GetComponent<ShipBase>())
        {
            other.GetComponent<ShipBase>().TakeDamage();
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
