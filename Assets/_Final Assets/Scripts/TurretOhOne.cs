using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretOhOne : MonoBehaviour
{
    [SerializeField]
    private Animator TurretAnimController;
    [SerializeField]
    private GameObject _turretProjectile;

    public GameObject firePoint01;
    public GameObject firePoint02;

    [Header("Turret State Changes")]

    private int _neutralToAction = 0;
    private bool _patrolLeftOrShoot = false;
    private bool _shootLeftAgain = false;
    private bool _patrolRightOrShoot = false;
    private bool _shootRightAgain = false;
    private bool _shootCenterAgain = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTurretBehavior()
    {
        _neutralToAction = Random.Range(-1, 2);
        //_patrolLeftOrShoot = (Random.Range(0, 1);
        TurretAnimController.SetFloat("NeutralToAction", _neutralToAction);
        
        int first = Random.Range(0, 2);        
        int second = (Random.Range(0, 2));
        int third = (Random.Range(0, 2));
        int forth = (Random.Range(0, 2));
        int fifth = (Random.Range(0, 2));
                
        TurretAnimController.SetBool("PatrolLeftOrShoot", first  == 0 ? true : false);        
        TurretAnimController.SetBool("ShootLeftAgain", second == 0 ? true : false);        
        TurretAnimController.SetBool("PatrolRightOrShoot", third == 0 ? true : false);        
        TurretAnimController.SetBool("ShootRightAgain", forth == 0 ? true : false);        
        TurretAnimController.SetBool("ShootCenterAgain", fifth == 0 ? true : false);

        //Debug.Log("coisou!!!");

        //Debug.Log("first = " + first);
        //Debug.Log("second = " + second);
        //Debug.Log("third = " + third);
        //Debug.Log("forth = " + forth);
        //Debug.Log("fifth = " + fifth);

    }

    public void TurretShot()
    {
        Quaternion rotation = firePoint01.transform.rotation;
        Instantiate(_turretProjectile, firePoint01.transform.position, rotation);
        rotation = firePoint02.transform.rotation;
        Instantiate(_turretProjectile, firePoint02.transform.position, rotation);
    }

    //Quaternion rotation = firePoints[i].transform.rotation;
    //Instantiate(projectile, firePoints[i].transform.position, rotation);



}
