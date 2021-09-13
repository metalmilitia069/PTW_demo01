using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "UIManager", menuName = "Managers/UI")]
public class UIManager_SO : ScriptableObject
{
    public Slider[] HPSliders;
    public Slider[] ShieldSliders;
    public Slider xpBar;


    public bool canUpdadeHUD = false;
    public bool canUpdadeLvl = false;

    private void OnDisable()
    {
        HPSliders = default;
        ShieldSliders = default;
    }
}
