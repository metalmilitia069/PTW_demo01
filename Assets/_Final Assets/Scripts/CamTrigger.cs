using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    [SerializeField]
    private Vector3 _originCoordinates;
    [SerializeField]
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShipBase>())
        {
            other.GetComponent<ShipBase>().controllerManager_SO.controlSwitcher = 2;

            float componentX;
            float componentY;
            float componentZ;

            while (other.transform.position != _originCoordinates)
            {
                if (other.transform.position.x - _originCoordinates.x > 0)
                {

                }

                if (other.transform.position.y - _originCoordinates.y > 0)
                {

                }

                if (other.transform.position.z - _originCoordinates.z > 0)
                {

                }
            }
        }
    }
}
