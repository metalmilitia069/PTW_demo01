using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisType : Debris
{
    // Start is called before the first frame update
    void Start()
    {
        _randomRotation = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (_isRotating)
        {
            RotateThis();
        }
    }
}
