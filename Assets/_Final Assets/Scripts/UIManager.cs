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
        HPUIUpdater1();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (uIManager_SO.canUpdadeHp)
        {
            HPUIUpdater1();
        }
    }

    public void HPUIUpdater()
    {
        uIManager_SO.canUpdadeHp = false;

        int hpLost = 0;
        for (int i = 0; i < shipStats_SO.playerHealth; i++)
        {
            uIManager_SO.HPSliders[i].value = 1;
            hpLost = i;
            Debug.Log("i = " + i);
            Debug.Log("hpLost = " + hpLost);
        }

        hpLost++;

        Debug.Log("hpLost = " + hpLost);

        for (int j = hpLost; j < HPSliders.Length; j++)//uIManager_SO.HPSliders.Length; j++)
        {
            //if (uIManager_SO.HPSliders[hpLost].IsActive())
            //{
                uIManager_SO.HPSliders[hpLost].value = 0;
            //}
        }

    }

    public void HPUIUpdater1()
    {
        uIManager_SO.canUpdadeHp = false;

        int hpLost = 0;
        for (int i = 0; i < uIManager_SO.HPSliders.Length -1; i++)
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
}
