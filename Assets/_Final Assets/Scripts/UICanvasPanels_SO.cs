using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "UICanvasPanels_SO", menuName = "UI/CanvasPanels")]
public class UICanvasPanels_SO : ScriptableObject
{
    [Header("UI Unlock Panels")]
    public bool IsUIPanelOn = false;
    [TextArea(2,20)]
    public string[] uIUnlockPanelTitle;
    [TextArea(15, 20)]
    public string[] uiUnlockPanelContent;
    public VideoClip[] videoClips;

    //[Header("UI Panels")]
    //public Gam
}
