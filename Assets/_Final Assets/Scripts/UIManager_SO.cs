using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private void OnDisable()
    {
        HPSliders = default;
        ShieldSliders = default;

        comunicationText = default;
        canDisplayCommunication = false;
    }
}
