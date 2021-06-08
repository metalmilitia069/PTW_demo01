using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBase : MonoBehaviour
{

    private float _movementInput;
    [SerializeField]
    private float _speed;
    private PlayerControls _playerControls;

    private float _playerMovementX;
    private float _playerMovementY;
    private float _playerMovementZ;
    private Vector3 _playerMovement = new Vector3();

    [SerializeField]
    protected GameObject[] firePoints;
    
    public ControllerManager_SO controllerManager_SO;
    public PlayerAmmunition_SO playerAmmunition_SO;

    private Vector3 playerPos;



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
    private float _fireRate = 1.5f;
    private float _timeToShoot = 0;

    private void Awake()
    {
        _playerControls = new PlayerControls();
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

        if (_playerControls.Shooting.FireButton.ReadValue<float>() != 0 && Time.time > _timeToShoot)
        {
            _timeToShoot = Time.time + _fireRate;            
            TopBackShoot();
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
                //_fireRate = 0.1f;
                //StartCoroutine(FireRate());
                Instantiate(playerAmmunition_SO.SingleShotTopBackLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.tripleShotLvl01:
                Instantiate(playerAmmunition_SO.TripleShotSideLvl01[0], firePoints[0].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl01[0], firePoints[1].transform.position, Quaternion.identity);
                Instantiate(playerAmmunition_SO.TripleShotSideLvl01[0], firePoints[2].transform.position, Quaternion.identity);
                break;
            case AmmunitionType.diagonalShotLvl01:
                break;
            case AmmunitionType.singleShotLvl02:
                break;
            case AmmunitionType.tripleShotLvl02:
                break;
            case AmmunitionType.diagonalShotLvl02:
                break;
            case AmmunitionType.singleShotLvl03:
                break;
            case AmmunitionType.tripleShotLvl03:
                break;
            case AmmunitionType.diagonalShotLvl03:
                break;
            default:
                break;
        }


    }

    

public IEnumerator FireRate()
    {
        yield return new WaitForSeconds(_fireRate);
        TopBackShoot();
    }


}
