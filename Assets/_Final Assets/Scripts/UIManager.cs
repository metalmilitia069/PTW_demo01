using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ShipStats_SO shipStats_SO;
    public UIManager_SO uIManager_SO;

    public Slider[] HPSliders;
    public Slider[] ShieldSliders;
    public Slider xpBar;
    public Text LevelText;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        uIManager_SO.HPSliders = HPSliders;
        uIManager_SO.ShieldSliders = ShieldSliders;
        XPUiUpdater();
        HPUIUpdater();
        ShieldUiUpdater();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (uIManager_SO.canUpdadeHUD)
        {
            if (uIManager_SO.canUpdadeLvl)
            {
                LevelUiUpdater();
                XPUiUpdater();
                uIManager_SO.canUpdadeLvl = false;
            }

            XPUiUpdater();
            HPUIUpdater();
            ShieldUiUpdater();

            uIManager_SO.canUpdadeHUD = false;
        }
    }    

    public void HPUIUpdater()
    {
        uIManager_SO.canUpdadeHUD = false;
        
        for (int i = 0; i < uIManager_SO.HPSliders.Length; i++)
        {
            if (uIManager_SO.HPSliders[i].IsActive())
            {
                uIManager_SO.HPSliders[i].value = 0;
            }
        }

        for (int j = 0; j < shipStats_SO.playerHealth; j++)
        {
            uIManager_SO.HPSliders[j].value = 1;
        }
    }

    public void ShieldUiUpdater()
    {
        for (int i = 0; i < uIManager_SO.ShieldSliders.Length; i++)
        {
            if (uIManager_SO.ShieldSliders[i].IsActive())
            {
                uIManager_SO.ShieldSliders[i].value = 0;
            }
        }

        for (int j = 0; j < shipStats_SO.playerShield; j++)
        {
            uIManager_SO.ShieldSliders[j].value = 1;
        }
    }

    public void XPUiUpdater()
    {
        xpBar.value = shipStats_SO.levelProgressionRate;
        ScoreText.text = shipStats_SO.playerScore.ToString("0000000");
    }

    public void LevelUiUpdater()
    {
        LevelText.text = "Lv. " + shipStats_SO.playerLevel.ToString("00");

        for (int i = 0; i < shipStats_SO.playerHealth; i++)
        {
            uIManager_SO.HPSliders[i].gameObject.SetActive(true);
            uIManager_SO.ShieldSliders[i].gameObject.SetActive(true);
        }
    }

}
