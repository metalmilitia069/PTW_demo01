using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "FortressDebris", menuName = "SpecializedDebris/Fortress")]
public class FortressDebris_SO : ScriptableObject
{
    public FortressDebris fortressDebris = default;

    public bool canMove = false;


    private void OnDisable()
    {
        fortressDebris = default;
        canMove = false;
    }
}
