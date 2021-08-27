using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaLevel01 : MonoBehaviour
{
    public CutSceneManager_SO cutSceneManager_SO;

    private void Awake()
    {
        cutSceneManager_SO.seaLevelRef = this.gameObject;
    }
}
