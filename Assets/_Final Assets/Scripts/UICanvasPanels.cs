using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UICanvasPanels : MonoBehaviour
{
    public UICanvasPanels_SO uICanvasPanels_SO;

    public GameObject[] uIPanels;
    public float tweenTime = 3.0f;

    [Header("Unlock Panel Setup")]
    public Text unlockPanelTitle;
    public Text unlockPanelContent;
    public VideoPlayer videoDemoUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    public void TweenPanelOn(int panelNumber)
    {
        LeanTween.scale(uIPanels[panelNumber], Vector3.one / 2, tweenTime);
    }

    public void SetupUnlockedShotPanel(int title, int content, int videoDemo)
    {
        unlockPanelTitle.text = uICanvasPanels_SO.uIUnlockPanelTitle[title];
        unlockPanelContent.text = uICanvasPanels_SO.uiUnlockPanelContent[content];
        videoDemoUI.clip = uICanvasPanels_SO.videoClips[videoDemo];
    }


}
