using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CutSceneCollection", menuName = "Managers/CutScenes")]
public class CutSceneManager_SO : ScriptableObject
{
    public enum CutScene
    {
        DivingSeaLvl01,
        none
    }

    public CutScene cutScene = CutScene.none;

    public ShipStats shipStatsRef = default;
    public GameObject seaLevelRef = default;

    private void OnDisable()
    {
        cutScene = CutScene.none;

        shipStatsRef = default;
        seaLevelRef = default;
    }
}
