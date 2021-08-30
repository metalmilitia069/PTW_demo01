using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressDebris_ControlTrigger : MonoBehaviour
{
    public FortressDebris_SO fortressDebris_SO;

    // Start is called before the first frame update
    void Start()
    {
        fortressDebris_SO.canMove = true;
        Destroy(this.gameObject, 5.0f);
    }    
}
