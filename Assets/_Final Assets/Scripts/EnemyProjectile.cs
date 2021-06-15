using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField]
    private float _speed = 15.0f;

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

    public void Move()
    {
        this.transform.position += this.transform.forward * _speed * Time.deltaTime;
    }
}
