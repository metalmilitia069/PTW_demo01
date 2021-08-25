using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaDebris : Debris
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShipStats>())
        {
            other.GetComponent<ShipStats>().TakeDamage();
        }
    }


}
