using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvasPanels : MonoBehaviour
{
    public UICanvasPanels_SO uICanvasPanels_SO;

    public GameObject[] uIPanels;
    public float tweenTime = 3.0f;

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


}
