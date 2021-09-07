using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CutSceneCollection", menuName = "Managers/CutScenes")]
public class CutSceneManager_SO : ScriptableObject
{
    public enum CutScene
    {
        DivingSeaLvl01,
        JumpingSeaLvl01,
        none
    }

    public CutScene cutScene = CutScene.none;

    public ShipStats shipStatsRef = default;
    public GameObject seaLevelRef = default;

    public FortressDebrisPartTwo FortressDebrisPartTwoRef = default;
    public AnimatinProp_SeaLvl01 Animation_Prop_CutSceneSeaLevel01 = default;

    private void OnDisable()
    {
        cutScene = CutScene.none;

        shipStatsRef = default;
        seaLevelRef = default;
        FortressDebrisPartTwoRef = default;
        Animation_Prop_CutSceneSeaLevel01 = default;
    }
}
