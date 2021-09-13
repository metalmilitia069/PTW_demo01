using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressDebris : Debris
{
    public FortressDebris_SO fortressDebris_SO;

    

    // Start is called before the first frame update
    void Start()
    {
        _randomRotation = Random.Range(0, 2);
        _randomRotation2 = Random.Range(0, 3);

        fortressDebris_SO.fortressDebris = this;        
    }

    // Update is called once per frame
    void Update()
    {
        if (fortressDebris_SO.PartOneCanMove)
        {
            Move();

            if (_isRotating)
            {
                RotateThis();
            }
        }
    }
}
