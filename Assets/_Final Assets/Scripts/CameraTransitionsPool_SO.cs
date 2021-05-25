using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "CameraPool", menuName = "CameraTransition")]
public class CameraTransitionsPool_SO : ScriptableObject
{    
    public GameObject[] camTransitionsArray = new GameObject[0];

    //public List<GameObject> list = new List<GameObject>();

    private void OnDisable()
    {
        camTransitionsArray = null;
    }

    
}
