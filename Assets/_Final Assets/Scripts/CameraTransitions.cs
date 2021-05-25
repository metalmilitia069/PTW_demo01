using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransitions : MonoBehaviour
{
    public CameraTransitionsPool_SO cameraTransitionsPool_SO;

    public GameObject[] camTransitionsArray = new GameObject[1];

    // Start is called before the first frame update
    void Start()
    {
        cameraTransitionsPool_SO.camTransitionsArray = camTransitionsArray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableCameraSets()
    {
        foreach (var item in camTransitionsArray)
        {
            if (item.gameObject.activeSelf)
            {
                item.gameObject.SetActive(false);
            }
        }
    }
}
