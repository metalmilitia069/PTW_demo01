using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "UIManager", menuName = "Managers/UI")]
public class UIManager_SO : ScriptableObject
{
    [Header("Player HUD")]
    public Slider[] HPSliders;
    public Slider[] ShieldSliders;
    public Slider xpBar;

    public Slider shotSlider;
    public Text ammunitionText = default;
    public Text shotLevelText;


    public bool canUpdadeHUD = false;
    public bool canUpdadeLvl = false;

    [Header("UI Messages")]
    public string comunicationText = default;
    public bool canDisplayCommunication = false;
    public int tweenNumber = 0;

    [Header("UI Unlock Panels")]
    public bool IsUIPanelOn = false;
    public bool canShowPanel = false;
    public int uIUnlockPanelTitleNumber = 0;
    public int uiUnlockPanelContentNumber = 0;
    public int videoClipNumber = 0;
    public int panelNumber = 0;



    public void SetupUnlockedShotPanel(int title, int content, int videoDemo, int panelNumberRef)
    {
        uIUnlockPanelTitleNumber = title;
        uiUnlockPanelContentNumber = content;
        videoClipNumber = videoDemo;
        panelNumber = panelNumberRef;

        canShowPanel = true;
    }


    private void OnDisable()
    {
        HPSliders = default;
        ShieldSliders = default;

        comunicationText = default;
        canDisplayCommunication = false;

        IsUIPanelOn = false;
        canShowPanel = false;
        uIUnlockPanelTitleNumber = 0;
        uiUnlockPanelContentNumber = 0;
        videoClipNumber = 0;
        panelNumber = 0;
    }
}
