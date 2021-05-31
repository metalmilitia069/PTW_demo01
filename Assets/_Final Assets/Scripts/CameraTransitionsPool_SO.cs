using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "CameraPool", menuName = "CameraTransition")]
public class CameraTransitionsPool_SO : ScriptableObject
{
    [TextArea]
    public string Decription;
    
    //Element 0 = Top to SIde Transition. Element 1 = Side to Top Transition. Element 2 = Top to Back Transition.
    //Element 3 = Back to Top Transition. Element 4 = Back to SIde Transition. Element 5 = Side to Back Transition.
    public GameObject[] camTransitionsArray = new GameObject[0];

    //public List<GameObject> list = new List<GameObject>();

    private void OnDisable()
    {
        camTransitionsArray = null;
    }

    
}
