using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public enum ProjectileType
    {
        type01,
        type02,
        type03
    }

    public ProjectileType projectileType;


    [SerializeField]
    private float _bulletSpeed;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        switch (projectileType)
        {
            case ProjectileType.type01:

                break;
            case ProjectileType.type02:
                break;
            case ProjectileType.type03:
                break;
            default:
                break;
        }
    }
}
