using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    [SerializeField]
    private bool deathOnContact;

    private bool canDamage = true;

    // Start is called before the first frame update
    void Start()
    {
        canDamage = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.GetComponent<ShipStats>() && canDamage)
        {
            canDamage = false;            
                                        
            if (deathOnContact)
            {
                other.GetComponent<ShipStats>().KillShip();
            }
            else
            {
                other.GetComponent<ShipStats>().TakeDamage();
            }            
        }
    }
}
