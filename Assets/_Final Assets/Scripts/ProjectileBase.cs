using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

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
        Destroy(this.gameObject, 5.0f);
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

    public void KillProjectile()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyBehavior>())
        {
            other.GetComponent<EnemyBehavior>().visualEffectPrefab.transform.position = this.transform.position;
            other.GetComponent<EnemyBehavior>().visualEffectPrefab.GetComponentInChildren<VisualEffect>().Reinit();
        }
        else if (other.GetComponent<EnemyBehaviorGunShip>())
        {
            other.GetComponent<EnemyBehaviorGunShip>().visualEffectPrefab.transform.position = this.transform.position;
            other.GetComponent<EnemyBehaviorGunShip>().visualEffectPrefab.GetComponentInChildren<VisualEffect>().Reinit();
        }
        else if (other.GetComponent<EnemyBehaviorShieldedTurret>())
        {
            other.GetComponent<EnemyBehaviorShieldedTurret>().visualEffectPrefab.transform.position = this.transform.position;
            other.GetComponent<EnemyBehaviorShieldedTurret>().visualEffectPrefab.GetComponentInChildren<VisualEffect>().Reinit();
        }
    }

}
