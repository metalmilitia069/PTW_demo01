using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public CameraTransitionsPool_SO cameraTransitionsPool_SO;
    public SpawnManager_SO spawnManager_SO;

    [SerializeField]
    private Vector3 _originCoordinates;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private bool isLockControls = false;

    private ShipBase shipBase;

    private GameObject _cameraGroup;

    [SerializeField]
    private float _triggerSpeed;
    
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
        this.transform.position += new Vector3(0, 0, (_speed * Time.deltaTime * -1));


        if (isLockControls)
        {
            float componentX;
            float componentY;
            float componentZ;

            shipBase.controllerManager_SO.controlSwitcher = 2;

            //Automatically Repositioning Player
            if (Vector3.Distance(shipBase.transform.position, _originCoordinates) > 1f)
            {
                if (shipBase.transform.position.x - _originCoordinates.x > 0)
                {
                    componentX = -1 * _speed * Time.deltaTime;
                }
                else
                {
                    componentX = _speed * Time.deltaTime;
                }

                if (shipBase.transform.position.y - _originCoordinates.y > 0)
                {
                    componentY = -1 * _speed * Time.deltaTime;
                }
                else
                {
                    componentY = _speed * Time.deltaTime;
                }

                if (shipBase.transform.position.z - _originCoordinates.z > 0)
                {
                    componentZ = -1 * _speed * Time.deltaTime;
                }
                else
                {
                    componentZ = _speed * Time.deltaTime;
                }
                //Debug.Log("Z:" + componentZ);
                shipBase.transform.position += new Vector3(componentX, componentY, componentZ);
            }
            //Change Cameras, then Release Controls
            else
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

                if (!_cameraGroup.activeSelf)
                {
                    switch (controlOptions)
                    {
                        case controlOptionsEnum.topControls:
                            shipBase.controllerManager_SO.controlSwitcher = -1;
                            break;
                        case controlOptionsEnum.sideControls:
                            shipBase.controllerManager_SO.controlSwitcher = 0;
                            break;
                        case controlOptionsEnum.backControls:
                            shipBase.controllerManager_SO.controlSwitcher = 1;
                            break;
                        default:
                            break;
                    }

                    spawnManager_SO.isPaused = false;
                    isLockControls = false;                
                }



            } 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShipBase>())
        {
            
            isLockControls = true;
            shipBase = other.GetComponent<ShipBase>();

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
