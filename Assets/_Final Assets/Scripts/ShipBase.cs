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
    //[SerializeField]
    //private bool _movementSwitch = true;
    //[SerializeField]
    //[Range(-1, 1)]
    //private int _movementSwitch;

    public ControllerManager_SO controllerManager_SO;

    private Vector3 playerPos;

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
                break;
            case 0:
                SideViewMovement();
                break;
            case 1:
                BackViewMovement();
                break;
            default:
                break;
        }
                
        this.transform.position += _playerMovement;
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

        //if (_playerMovementX < 0 && this.transform.localEulerAngles.z < 15)// && this.transform.localEulerAngles.z < 16)
        //{
        //    this.transform.Rotate(new Vector3(0,0, Mathf.Lerp(0, 15, 1)));
        //}
        //else if (_playerMovementX > 0 && this.transform.localEulerAngles.z > -15 && this.transform.localEulerAngles.z <= 0)
        //{
        //    this.transform.Rotate(new Vector3(0, 0, Mathf.Lerp(0, -15, 1)));
        //}
        //else
        //{
        //    //this.transform.rotation.z = 0;
        //}

        //this.transform.rotation = Quaternion.AngleAxis(1.0f, Vector3.forward * Mathf.Lerp(Random.Range(-2, 2), Random.Range(-2, 2), 1) * Time.deltaTime);

        //if (_playerMovementX != 0)
        //{
        //    //this.gameObject.GetComponent<Animator>().SetBool("SteerBool", true);
        //    this.gameObject.GetComponent<Animator>().SetFloat("SteerFloat", _playerMovementX);
        //}
        //else
        //{
        //    this.gameObject.GetComponent<Animator>().SetBool("SteerBool", false);
        //}



        //this.transform.rotation = Quaternion.AngleAxis(15.0f, Vector3.forward * _playerMovementX * -1);

        Debug.Log(_playerMovementX);
        this.gameObject.GetComponent<Animator>().SetFloat("SteerFloat", _playerMovementX);


        _playerMovement = new Vector3(_playerMovementX, 0, _playerMovementZ);
    }

    private void BackViewMovement()
    {
        _playerMovementY = _playerControls.LocomotionSideView.VerticalMove.ReadValue<float>() * _speed * Time.deltaTime;
        _playerMovementX = _playerControls.LocomotionTopView.SideMove.ReadValue<float>() * _speed * Time.deltaTime;

        _playerMovement = new Vector3(_playerMovementX, _playerMovementY, 0);
    }


}
