using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{

    public CutSceneManager_SO cutSceneManager_SO;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (!cutSceneManager_SO)
        {
            return;
        }
        else
        {
            if (cutSceneManager_SO.cutScene == CutSceneManager_SO.CutScene.none)
            {
                return;
            }
            else
            {
                PlayCutScenes();
            }
        }
    }

    public void PlayCutScenes()
    {
        switch (cutSceneManager_SO.cutScene)
        {
            case CutSceneManager_SO.CutScene.DivingSeaLvl01:
                PlayDivingSeaLvl01();
                cutSceneManager_SO.cutScene = CutSceneManager_SO.CutScene.none;
                break;
            case CutSceneManager_SO.CutScene.none:
                break;
            default:
                break;
        }


    }

    public void PlayDivingSeaLvl01()
    {
        cutSceneManager_SO.shipStatsRef.GetComponent<Animator>().SetTrigger("DivingTrigger");
        cutSceneManager_SO.seaLevelRef.GetComponent<Animator>().SetTrigger("DivingTrigger");
    }
}
