using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName ="SeaDebrisEndWallState", menuName = "SeaDebrisWall")]
public class SeaDebrisEndWall_SO : ScriptableObject
{
    public bool isKillingSeaDebris = false;

    private void OnDisable()
    {
        isKillingSeaDebris = false;
    }
}
