using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasMsg : MonoBehaviour
{
    public float tweenTime;

    public Text msgText;

    // Start is called before the first frame update
    void Start()
    {
        TweenThis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TweenThis()
    {
        msgText.gameObject.SetActive(true);
        LeanTween.alpha(msgText.gameObject, 1f, 1f);
        LeanTween.scale(msgText.gameObject, Vector3.one * 2, tweenTime).setEasePunch().setOnComplete(HideUI);
        //msgText.gameObject.SetActive(false);
    }

    public void HideUI()
    {
        msgText.gameObject.SetActive(false);
    }
}
