using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBase : MonoBehaviour
{
    private float _movementInput;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected int _playerHealth = 10;
    protected PlayerControls _playerControls;

    protected float _playerMovementX;
    protected float _playerMovementY;
    protected float _playerMovementZ;
    protected Vector3 _playerMovement = new Vector3();

    [SerializeField]
    protected GameObject[] firePoints;


    
    public ControllerManager_SO controllerManager_SO;
    public PlayerAmmunition_SO playerAmmunition_SO;
    public GameManager_SO gameManager_SO;

    protected Vector3 playerPos;



    public enum AmmunitionType
    {
        //straightTopBack,
        //leftTopBack,
        //rightTopBack,
        //straightSide,
        //upwardSide,
        //dowardSide,
        singleShotLvl01,
        tripleShotLvl01,
        diagonalShotLvl01,
        singleShotLvl02,
        tripleShotLvl02,
        diagonalShotLvl02,
        singleShotLvl03,
        tripleShotLvl03,
        diagonalShotLvl03

    }

    public AmmunitionType ammunitionType;

    [SerializeField]
    protected float _fireRate = 1.5f;
    protected float _timeToShoot = 0;

    private void Awake()
    {
        _playerControls = new PlayerControls();
        gameManager_SO.shipBase = this;
        //_playerControls.Shooting.FireButton.started += _ => TopBackShoot();
        //_playerControls.Shooting.FireButton. += _ => TopBackShoot();
        //_playerControls.Shooting.FireButton.performed += _ => TopBackShoot();
        //_playerControls.Shooting.FireButton.canceled += _ => TopBackShoot();
        //_playerControls.Shooting.FireButton.ReadValue
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
        //_playerControls.Shooting.FireButton.performed -= _ => TopBackShoot();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();

    }

    protected void Shooting()
    {
        if (_playerControls.Shooting.FireButton.ReadValue<float>() != 0 && Time.time > _timeToShoot)
        {
            switch (controllerManager_SO.controlSwitcher)
            {
                case -1:
                    TopBackShoot();
                    break;
                case 0:
                    SideShoot();
                    break;
                case 1:
                    TopBackShoot();
                    break;
                default:
                    break;
            }
            _timeToShoot = Time.time + _fireRate;

        }

        
    }    

    protected void Movement()
    {
        switch (controllerManager_SO.controlSwitcher)//(_movementSwitch)
        {
            case -1:
                TopViewMovement();
                this.transform.position += _playerMovement;
                break;
            case 0:
                SideViewMovement();
                this.transform.position += _playerMovement;
                break;
            case 1:
                BackViewMovement();
                this.transform.position += _playerMovement;
                break;
            default:
                break;
        }
    }

    private void SideViewMovement()
    {
        _playerMovementY = _playerControls.LocomotionSideView.VerticalMove.ReadValue<float>() * _speed * Time.deltaTime;
        _playerMovementZ = _playerControls.LocomotionSideView.ForwardMove.ReadValue<float>() * _speed * Time.deltaTime;

        _playerMovement = new Vector3(0, _playerMovementY, _playerMovementZ);
    }

    private void TopViewMovement()
    {
        _playerMovementX = _playerControls.LocomotionTopView.SideMove.ReadValue<float>() * _speed * Time.deltaTime;
        _playerMovementZ = _playerControls.LocomotionTopView.ForwardMove.ReadValue<float>() * _speed * Time.deltaTime;

        Vector3 axis = new Vector3();        

        //Debug.Log(_playerMovementX);
        this.gameObject.GetComponent<Animator>().SetFloat("SteerFloat", _playerMovementX);


        _playerMovement = new Vector3(_playerMovementX, 0, _playerMovementZ);
    }

    private void BackViewMovement()
    {
        _playerMovementY = _playerControls.LocomotionSideView.VerticalMove.ReadValue<float>() * _speed * Time.deltaTime;
        _playerMovementX = _playerControls.LocomotionTopView.SideMove.ReadValue<float>() * _speed * Time.deltaTime;

        _playerMovement = new Vector3(_playerMovementX, _playerMovementY, 0);
    }

    public void TopBackShoot()
    {
        switch (ammunitionType)
        {
            case AmmunitionType.singleShotLvl01:                
                Instantiate(playerAmmunition_SO.SingleShotTopBackLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl01:
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl01[1], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl01[2], firePoints[2].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl01:
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl01[1], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl01[2], firePoints[2].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.singleShotLvl02:
                Instantiate(playerAmmunition_SO.SingleShotTopBackLvl02[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl02:
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl02[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl02[1], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl02[2], firePoints[2].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl02:
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl02[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl02[1], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl02[2], firePoints[2].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.singleShotLvl03:
                Instantiate(playerAmmunition_SO.SingleShotTopBackLvl03[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl03:
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl03[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl03[1], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotTopBackLvl03[2], firePoints[2].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl03:
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl03[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl03[1], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotTopBackLvl03[2], firePoints[2].transform.position, Quaternion.identity);
                break;
            default:
                break;
        }


    }

    public void SideShoot()
    {
        switch (ammunitionType)
        {
            case AmmunitionType.singleShotLvl01:
                Instantiate(playerAmmunition_SO.SingleShotSideLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl01:
                Instantiate(playerAmmunition_SO.TripleShotSideLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl01[0], firePoints[3].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl01[0], firePoints[4].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl01:
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl01[1], firePoints[3].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl01[2], firePoints[4].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.singleShotLvl02:
                Instantiate(playerAmmunition_SO.SingleShotSideLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl02:
                Instantiate(playerAmmunition_SO.TripleShotSideLvl02[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl02[0], firePoints[3].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl02[0], firePoints[4].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl02:
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl02[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl02[1], firePoints[3].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl02[2], firePoints[4].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.singleShotLvl03:
                Instantiate(playerAmmunition_SO.SingleShotSideLvl03[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl03:
                Instantiate(playerAmmunition_SO.TripleShotSideLvl03[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl03[0], firePoints[3].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl03[0], firePoints[4].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl03:
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl03[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl03[1], firePoints[3].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.DiagonalShotSideLvl03[2], firePoints[4].transform.position, Quaternion.identity);
                break;
            default:
                break;
        }


    }

    //public void TakeDamage()
    //{
    //    if (_playerHealth <= 0)
    //    {
    //        IsPlayerDead();
    //    }
    //    else
    //    {
    //        _playerHealth--;
    //    }
    //}

    public bool IsPlayerDead()
    {
        Destroy(this.gameObject, 0.5f);

        return true;
    }

    //private void OnTriggerEnter(Collider other)
    //{
        
    //}


    //public IEnumerator FireRate()
    //{
    //    yield return new WaitForSeconds(_fireRate);
    //    TopBackShoot();
    //}




}
