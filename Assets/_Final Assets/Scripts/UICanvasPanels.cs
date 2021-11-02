using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UICanvasPanels : MonoBehaviour
{
    public UIManager_SO uIManager_SO;
    public UICanvasPanels_SO uICanvasPanels_SO;

    public GameObject[] uIPanels;
    public float tweenTime = 3.0f;

    [Header("Unlock Panel Setup")]
    public Text unlockPanelTitle;
    public Text unlockPanelContent;
    public VideoPlayer videoDemoUI;


    //public bool canClosePanel = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (uICanvasPanels_SO.canShowPanel)
        {
            if (uICanvasPanels_SO.panelNumber == 0)
            {
                //SetupUnlockedShotPanel(uICanvasPanels_SO.title, uICanvasPanels_SO.content, uICanvasPanels_SO.videoDemo);
                SetupUnlockedShotPanel();
            }
            TweenPanelOn(uIManager_SO.panelNumber);

            uICanvasPanels_SO.canShowPanel = false;
        }

        if (uIManager_SO.canCloseUIPanel)
        {
            uIManager_SO.canCloseUIPanel = false;
            TurnPanelOff();
        }
    }

    public void TweenPanelOn(int panelNumber)
    {
        TurnPanelOff();

        uIPanels[panelNumber].gameObject.SetActive(true);
        LeanTween.scale(uIPanels[panelNumber], Vector3.one / 1.5f, tweenTime).setEasePunch();
        
    }

    public void TurnPanelOff()
    {
        foreach (var panel in uIPanels)
        {
            if (panel.gameObject.activeSelf)
            {
                panel.gameObject.SetActive(false);
            }
        }
        uIManager_SO.canOpenUIPanel = true;
    }

    public void SetupUnlockedShotPanel() //(int title, int content, int videoDemo)
    {
        //unlockPanelTitle.text = uICanvasPanels_SO.uIUnlockPanelTitle[title];
        //unlockPanelContent.text = uICanvasPanels_SO.uiUnlockPanelContent[content];
        //videoDemoUI.clip = uICanvasPanels_SO.videoClips[videoDemo];

        unlockPanelTitle.text = uICanvasPanels_SO.panelTitle;
        unlockPanelContent.text = uICanvasPanels_SO.panelContent;
        videoDemoUI.clip = uICanvasPanels_SO.videoDemo;
    }

    
}
