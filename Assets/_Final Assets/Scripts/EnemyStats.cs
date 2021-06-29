using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : EnemyBase
{
    [Header("Enemy Stats")]
    [SerializeField]
    protected int health = 100;
    [SerializeField]
    protected int shields = 0;
    [SerializeField]
    protected int pointsWorth = 10;
    [SerializeField]
    protected float fireRate = 0.5f;
    [SerializeField]
    protected GameObject projectile;
    [SerializeField]
    protected float manouverSpeed = 10.0f;
    [SerializeField]
    public float respawnZCoord;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
