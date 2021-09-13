using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressDebrisControlTriggerPart2 : MonoBehaviour
{
    public FortressDebris_SO fortressDebris_SO;


    // Start is called before the first frame update
    void Start()
    {
        fortressDebris_SO.PartTwoCanMove = true;
        
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
