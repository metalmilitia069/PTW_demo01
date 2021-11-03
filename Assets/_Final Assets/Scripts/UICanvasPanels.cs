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


    private bool _preventPauseMenu = false;

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

        if (uIManager_SO.canTogglePauseMenu)
        {
            TogglePauseMenu();
        }
    }

    public LeanTweenType leanTween;

    public void TweenPanelOn(int panelNumber)
    {
        TurnPanelOff();
        //LeanTween.cancelAll();

        uIPanels[panelNumber].gameObject.SetActive(true);
        uIPanels[panelNumber].gameObject.transform.localScale = Vector3.one * 0.1f;
        LeanTween.scale(uIPanels[panelNumber], Vector3.one  , tweenTime).setOnComplete(PauseGame);//.setEase(leanTween);//.setOnComplete(PauseGame);// (LeanTweenType.animationCurve);//  .setEasePunch().setOnComplete(PauseGame);
        //PauseGame();
        _preventPauseMenu = false;
    }

    public void PauseGame()
    {
        //if (Time.timeScale == 1)
        //{
            Time.timeScale = 0;
        //}
    }

    public void UnpauseGame()
    {
        //if (Time.timeScale == 0)
        //{
            Time.timeScale = 1;
        //}
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
        UnpauseGame();
        _preventPauseMenu = false;
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

    public void TogglePauseMenu()
    {
        uIManager_SO.canTogglePauseMenu = false;
        if (_preventPauseMenu)
        {
            return;
        }
        _preventPauseMenu = true;
        if (uIPanels[1].gameObject.activeSelf)
        {
            TurnPanelOff();
        }
        else
        {
            //_preventPauseMenu = true;
            //TurnPanelOff();
            TweenPanelOn(1);
            //_preventPauseMenu = false;
        }
        //_preventPauseMenu = false;
    }

    
}
