using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatinProp_SeaLvl01 : MonoBehaviour
{
    public CutSceneManager_SO cutSceneManager_SO;

    // Start is called before the first frame update
    void Awake()
    {
        cutSceneManager_SO.Animation_Prop_CutSceneSeaLevel01 = this;
    }

    
}
