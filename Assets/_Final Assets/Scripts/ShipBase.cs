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
        straightTopBack,
        leftTopBack,
        rightTopBack,
        straightSide,
        upwardSide,
        dowardSide,

    }

    public AmmunitionType ammunitionType;


    private void Awake()
    {
        _playerControls = new PlayerControls();
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
                
        //this.transform.position += _playerMovement;
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

    public void Shoot()
    {

    }


}
