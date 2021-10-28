using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ShipStats_SO shipStats_SO;
    public UIManager_SO uIManager_SO;
    public UICanvasMsg_SO uICanvasMsg_SO;


    public Slider[] HPSliders;
    public Slider[] ShieldSliders;
    public Slider xpBar;
    public Text LevelText;
    public Text ScoreText;

    //public Slider singleShotSlider;
    //public Slider tripleShotSlider;
    //public Slider diagonalShotSlider;
    public Slider shotSlider;
    public Text ammunitionText;
    public Text shotLevelText;


    // Start is called before the first frame update
    void Start()
    {
        uIManager_SO.HPSliders = HPSliders;
        uIManager_SO.ShieldSliders = ShieldSliders;
        uIManager_SO.xpBar = xpBar;

        uIManager_SO.shotSlider = shotSlider;
        uIManager_SO.ammunitionText = ammunitionText;
        uIManager_SO.shotLevelText = shotLevelText;

        LevelUiUpdater();
        XPUiUpdater();
        HPUIUpdater();
        ShieldUiUpdater();
        ShotTypeUIUpdater();
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
            ShotTypeUIUpdater();
                        
            uIManager_SO.canUpdadeHUD = false;
        }

        if (uIManager_SO.canDisplayCommunication)
        {
            uICanvasMsg_SO.communicationText = uIManager_SO.comunicationText;
            uICanvasMsg_SO.canDisplayCommunication = true;
            uIManager_SO.canDisplayCommunication = false;
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
        //xpBar.value = shipStats_SO.levelProgressionRate;  << OLD SOLUTION!!! STILL WORKS!!!!
        uIManager_SO.xpBar.value = shipStats_SO.levelProgressionRate;
        ScoreText.text = shipStats_SO.playerScore.ToString("0000000");
    }

    public void LevelUiUpdater()
    {
        if (shipStats_SO.playerLevel == shipStats_SO.maxLevel)
        {
            LevelText.text = "MAX";
            return;
        }

        LevelText.text = "Lv. " + shipStats_SO.playerLevel.ToString("00");

        for (int i = 0; i < shipStats_SO.playerHealth; i++)
        {
            uIManager_SO.HPSliders[i].gameObject.SetActive(true);
            uIManager_SO.ShieldSliders[i].gameObject.SetActive(true);
        }
    }   

    public void ShotTypeUIUpdater()
    {
        //public Slider shotSlider;
        //public Text ammunitionText;
        //public Text shotLevelText;

        shotSlider.value = shipStats_SO.ammunitionProgressionRate;
        ammunitionText.text = shipStats_SO.ammunitionName;
        if (shipStats_SO.ammunitionLevel == 3)
        {
            shotLevelText.text = "Max";
        }
        else
        {
            shotLevelText.text = "Lv. 0" + shipStats_SO.ammunitionLevel.ToString();
        }
        
    }



}
