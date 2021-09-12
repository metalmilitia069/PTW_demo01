using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnabler : MonoBehaviour
{
    public FortressDebris_SO fortressDebris_SO;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ShipStats>())
        {
            fortressDebris_SO.PartTwoEnabled = true;
        }
    }
}
