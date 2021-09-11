using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : CamTrigger
{
    public CutSceneManager_SO cutSceneManager_SO;
    private bool canPlayAnim = true;

    public float animationPlayTime;

    public enum CutScene
    {
        DivingSeaLvl01,
        JumpingSeaLvl01,
        none
    }

    public CutScene cutScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        

        if (isLockControls)
        {
            FreezeShipControls();

            //Automatically Repositioning Player
            if (Vector3.Distance(shipStats.transform.position, _originCoordinates) > 1f)
            {
                //Debug.Log("Ein?!?!");
                SendPlayerToOriginCoordinates();
            }
            //Change Cameras, then Release Controls
            else
            {                
                SwitchCamera();
                if (cutScene != CutScene.none && canPlayAnim)
                {
                    canPlayAnim = false;
                    shipStats.GetComponent<ShipStats>().isShipFrozen = true;
                    StartCoroutine(PlaySequence());
                    
                }
            }
        }
    }

    public IEnumerator PlaySequence()
    {
        //StopAllCoroutines();
        yield return new WaitForSeconds(10.0f);

        switch (cutScene)
        {
            case CutScene.DivingSeaLvl01:
                cutSceneManager_SO.cutScene = CutSceneManager_SO.CutScene.DivingSeaLvl01;
                //cutSceneManager_SO.cutScene = CutSceneManager_SO.CutScene.none;
                //Destroy(this.gameObject);
                break;
            case CutScene.JumpingSeaLvl01:
                cutSceneManager_SO.cutScene = CutSceneManager_SO.CutScene.JumpingSeaLvl01;
                break;
            case CutScene.none:
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(animationPlayTime);
        UnlockControls();
        shipStats.GetComponent<ShipStats>().isShipFrozen = false;
        Destroy(this.gameObject);
        //StopAllCoroutines();
    }


}


