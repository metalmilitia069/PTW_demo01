using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public CameraTransitionsPool_SO cameraTransitionsPool_SO;
    public SpawnManager_SO spawnManager_SO;

    [SerializeField]
    protected Vector3 _originCoordinates;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected bool isLockControls = false;
    [SerializeField]
    protected bool _unpauseSpanwer = false;

    [SerializeField]
    protected ShipBase shipStats;

    protected GameObject _cameraGroup;



    [SerializeField]
    //protected float _triggerSpeed;
    protected float _shipSpeed = 60.0f;

    public enum controlOptionsEnum
    {
        topControls,
        sideControls,
        backControls
    }

    public enum cameraOptionsEnum
    {
        topToSide,
        sideToTop,
        topToBack,
        backToTop,
        backToSide,
        sideToBack,
        none
    }

    public controlOptionsEnum controlOptions;
    public cameraOptionsEnum cameraOptions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (isLockControls)
        {
            FreezeShipControls();

            //Automatically Repositioning Player
            if (Vector3.Distance(shipStats.transform.position, _originCoordinates) > 1f)
            {
                SendPlayerToOriginCoordinates();
            }
            //Change Cameras, then Release Controls
            else
            {
                SwitchCamera();
                UnlockControls();
            }
        }
    }

    protected void Move()
    {
        this.transform.position += new Vector3(0, 0, (_speed * Time.deltaTime * -1));
    }

    protected void SwitchCamera()
    {
        switch (cameraOptions)
        {
            case cameraOptionsEnum.topToSide:
                cameraTransitionsPool_SO.camTransitionsArray[0].gameObject.SetActive(true);
                _cameraGroup = cameraTransitionsPool_SO.camTransitionsArray[0];
                cameraOptions = cameraOptionsEnum.none;
                break;
            case cameraOptionsEnum.sideToTop:
                cameraTransitionsPool_SO.camTransitionsArray[1].gameObject.SetActive(true);
                _cameraGroup = cameraTransitionsPool_SO.camTransitionsArray[1];
                cameraOptions = cameraOptionsEnum.none;
                break;
            case cameraOptionsEnum.topToBack:
                cameraTransitionsPool_SO.camTransitionsArray[2].gameObject.SetActive(true);
                _cameraGroup = cameraTransitionsPool_SO.camTransitionsArray[2];
                cameraOptions = cameraOptionsEnum.none;
                break;
            case cameraOptionsEnum.backToTop:
                cameraTransitionsPool_SO.camTransitionsArray[3].gameObject.SetActive(true);
                _cameraGroup = cameraTransitionsPool_SO.camTransitionsArray[3];
                cameraOptions = cameraOptionsEnum.none;
                break;
            case cameraOptionsEnum.backToSide:
                cameraTransitionsPool_SO.camTransitionsArray[4].gameObject.SetActive(true);
                _cameraGroup = cameraTransitionsPool_SO.camTransitionsArray[4];
                cameraOptions = cameraOptionsEnum.none;
                break;
            case cameraOptionsEnum.sideToBack:
                cameraTransitionsPool_SO.camTransitionsArray[5].gameObject.SetActive(true);
                _cameraGroup = cameraTransitionsPool_SO.camTransitionsArray[5];
                cameraOptions = cameraOptionsEnum.none;
                break;
            default:
                break;
        }

        //UnlockControls();
    }

    protected void UnlockControls()
    {
        //if (!_cameraGroup.activeSelf)
        //{
        Debug.Log("UnlockControls?????");
            switch (controlOptions)
            {
                case controlOptionsEnum.topControls:
                    shipStats.controllerManager_SO.controlSwitcher = -1;
                    break;
                case controlOptionsEnum.sideControls:
                    shipStats.controllerManager_SO.controlSwitcher = 0;
                    break;
                case controlOptionsEnum.backControls:
                    shipStats.controllerManager_SO.controlSwitcher = 1;
                    break;
                default:
                    break;
            }

            if (_unpauseSpanwer)
            {
                spawnManager_SO.isPaused = false;
            }

            isLockControls = false;
        //}
    }

    protected void SendPlayerToOriginCoordinates()
    {
        float componentX;
        float componentY;
        float componentZ;
        
        if (shipStats.transform.position.x - _originCoordinates.x > 0)
        {
            componentX = -1 * _shipSpeed * Time.deltaTime;
        }
        else
        {
            componentX = _shipSpeed * Time.deltaTime;
        }

        if (shipStats.transform.position.y - _originCoordinates.y > 0)
        {
            componentY = -1 * _shipSpeed * Time.deltaTime;
        }
        else
        {
            componentY = _shipSpeed * Time.deltaTime;
        }

        if (shipStats.transform.position.z - _originCoordinates.z > 0)
        {
            componentZ = -1 * _shipSpeed * Time.deltaTime;
        }
        else
        {
            componentZ = _shipSpeed * Time.deltaTime;
        }
        //Debug.Log("Z:" + componentZ);
        //shipStats.transform.position += new Vector3(componentX, componentY, componentZ);
        shipStats.gameObject.transform.Translate(Vector3.Lerp(shipStats.transform.position, new Vector3(componentX, componentY, componentZ), _shipSpeed));
    }

    protected void FreezeShipControls()
    {
        shipStats.controllerManager_SO.controlSwitcher = 2;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShipStats>())
        {
            Debug.Log("triggou a Nave");
            isLockControls = true;
            shipStats = other.GetComponent<ShipStats>();

            //other.GetComponent<ShipBase>().controllerManager_SO.controlSwitcher = 2;

            //float componentX;
            //float componentY;
            //float componentZ;


            //while (Vector3.Distance(other.transform.position, _originCoordinates) > 1f)
            //{
            //    if (other.transform.position.x - _originCoordinates.x > 0)
            //    {
            //        componentX = -1 * _speed * Time.deltaTime;
            //    }
            //    else
            //    {
            //        componentX = _speed * Time.deltaTime;
            //    }

            //    if (other.transform.position.y - _originCoordinates.y > 0)
            //    {
            //        componentY = -1 * _speed * Time.deltaTime;
            //    }
            //    else
            //    {
            //        componentY = _speed * Time.deltaTime;
            //    }

            //    if (other.transform.position.z - _originCoordinates.z > 0)
            //    {
            //        componentZ = -1 * _speed * Time.deltaTime;
            //    }
            //    else
            //    {
            //        componentZ = _speed * Time.deltaTime;
            //    }

            //    other.transform.position += new Vector3(componentX, componentY, componentZ);
            //}
        }
    }
}
