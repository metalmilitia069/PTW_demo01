using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    [SerializeField]
    private Vector3 _originCoordinates;


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

        }
    }
}
