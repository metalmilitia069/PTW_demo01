using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    [SerializeField]
    private Vector3 _originCoordinates;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private bool unlock = false;

    private ShipBase shipBase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (unlock)
        {
            float componentX;
            float componentY;
            float componentZ;
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

                shipBase.transform.position += new Vector3(componentX, componentY, componentZ);
            }
            else
            {
                unlock = false;
            } 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShipBase>())
        {
            
            unlock = true;
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
