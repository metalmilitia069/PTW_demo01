using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTimelyDestruction : MonoBehaviour
{
    public float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }   
}
