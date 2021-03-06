using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CutSceneCanvas : MonoBehaviour
{
    public UIManager_SO uIManager_SO;


    public GameObject lowerPanel;
    public GameObject upperPanel;

    public CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.moveY(upperPanel, 2160, 0.5f);
        //LeanTween.moveY(lowerPanel, 0, .5f);
        ActivateTriangleUI();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (uIManager_SO.isCutSceneStarting)
        {
            ToggleCutSceneTabs();
        }
    }

    public void ToggleCutSceneTabs()
    {
        if (lowerPanel.gameObject.activeSelf)
        {
            uIManager_SO.isCutSceneStarting = false;
            LeanTween.moveY(upperPanel, 2475, 0.5f);
            LeanTween.moveY(lowerPanel, -325, 0.5f).setOnComplete(TurnCutScenePanelsOff);
            //lowerPanel.gameObject.SetActive(false);
            //upperPanel.gameObject.SetActive(false);
        }
        else
        {
            uIManager_SO.isCutSceneStarting = false;
            lowerPanel.gameObject.SetActive(true);
            upperPanel.gameObject.SetActive(true);
            LeanTween.moveY(upperPanel, 2160, 0.5f);
            LeanTween.moveY(lowerPanel, 0, .5f);
        }

        
    }

    public void TurnCutScenePanelsOff()
    {
        lowerPanel.gameObject.SetActive(false);
        upperPanel.gameObject.SetActive(false);
    }

    public void ActivateTriangleUI()
    {
        //LeanTween.alpha(triangleUI, 0, 1.0f);//.setAlpha();
        LeanTween.alphaCanvas(canvasGroup, to: 1, 1.0f).setLoopClamp();
            
    }
}
