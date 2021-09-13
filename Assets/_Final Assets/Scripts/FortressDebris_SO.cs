using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FortressDebris", menuName = "SpecializedDebris/Fortress")]
public class FortressDebris_SO : ScriptableObject
{
    public FortressDebris fortressDebris = default;  //Delete maybe


    public bool PartOneCanMove = false;
    public bool PartTwoCanMove = false;
    public bool PartTwoEnabled = false;

    private void OnDisable()
    {
        fortressDebris = default;
        PartOneCanMove = false;
        PartTwoCanMove = false;
        PartTwoEnabled = false;
    }
}
