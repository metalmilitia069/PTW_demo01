using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressDebrisPartTwo : Debris
{
    public FortressDebris_SO fortressDebris_SO;


    // Start is called before the first frame update
    void Start()
    {
        _randomRotation = Random.Range(0, 2);
        _randomRotation2 = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (fortressDebris_SO.PartTwoCanMove)
        {
            Move();

            if (_isRotating)
            {
                RotateThis();
            }
        }
    }
}
