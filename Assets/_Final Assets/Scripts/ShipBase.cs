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
    private float _playerMovementZ;
    private Vector3 _playerMovement = new Vector3();

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
        _movementInput = _playerControls.LocomotionTopView.SideMove.ReadValue<float>();

        _playerMovementX = _playerControls.LocomotionTopView.SideMove.ReadValue<float>() * _speed * Time.deltaTime;
        _playerMovementZ = _playerControls.LocomotionTopView.ForwardMove.ReadValue<float>() * _speed * Time.deltaTime;

        _playerMovement = new Vector3(_playerMovementX, 0, _playerMovementZ);



        this.transform.position += _playerMovement;

        //playerPos = this.transform.position;

        //playerPos.x += (_movementInput * _speed * Time.deltaTime);

        //this.transform.position = playerPos;


    }
}
