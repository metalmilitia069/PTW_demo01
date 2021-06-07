using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public enum ProjectileType
    {
        straightTopBack,
        leftTopBack,
        rightTopBack,
        straightSide,
        upwardSide,
        dowardSide,

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
        Move();
    }

    public void Move()
    {
        switch (projectileType)
        {
            case ProjectileType.straightTopBack:
                this.transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
                break;
            case ProjectileType.leftTopBack:
                this.transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
                this.transform.position += Vector3.left * _bulletSpeed * Time.deltaTime;
                break;
            case ProjectileType.rightTopBack:
                this.transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
                this.transform.position += Vector3.right * _bulletSpeed * Time.deltaTime;
                break;
            case ProjectileType.straightSide:
                this.transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
                break;
            case ProjectileType.upwardSide:
                this.transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
                this.transform.position += Vector3.up * _bulletSpeed * Time.deltaTime;
                break;
            case ProjectileType.dowardSide:
                this.transform.position += Vector3.forward * _bulletSpeed * Time.deltaTime;
                this.transform.position += Vector3.down * _bulletSpeed * Time.deltaTime;
                break;
            default:
                break;
        }

        
    }
}
