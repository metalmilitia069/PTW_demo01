using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressDebris_ControlTrigger : MonoBehaviour
{
    public FortressDebris_SO fortressDebris_SO;
    public SeaDebrisEndWall_SO seaDebrisEndWall_SO;

    // Start is called before the first frame update
    void Start()
    {
        fortressDebris_SO.PartOneCanMove = true;
        seaDebrisEndWall_SO.isKillingSeaDebris = true;
        seaDebrisEndWall_SO.isKillingSeaDebris = true;
        Destroy(this.gameObject, 5.0f);
    }    
}
