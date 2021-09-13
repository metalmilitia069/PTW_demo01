using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisType : Debris
{
    // Start is called before the first frame update
    void Start()
    {
        _randomRotation = Random.Range(0, 2);
        _randomRotation2 = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (_isRotating)
        {
            RotateThis();
            RotateThis02();
        }
    }

    public void RotateThis02()
    {
        if (_randomRotation2 == 0)
        {
            this.transform.Rotate(Vector3.right * _rotationSpeed * Time.deltaTime);
        }
        else if (_randomRotation2 == 1)
        {
            this.transform.Rotate(Vector3.right * _rotationSpeed * Time.deltaTime * -1);
        }
    }
}
