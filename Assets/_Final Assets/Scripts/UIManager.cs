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

    // Start is called before the first frame update
    void Start()
    {
        uIManager_SO.HPSliders = HPSliders;
        uIManager_SO.ShieldSliders = ShieldSliders;
        HPUIUpdater();
        ShieldUiUpdater();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (uIManager_SO.canUpdadeHp)
        {
            HPUIUpdater();
            ShieldUiUpdater();
        }
    }    

    public void HPUIUpdater()
    {
        uIManager_SO.canUpdadeHp = false;

        
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
}
