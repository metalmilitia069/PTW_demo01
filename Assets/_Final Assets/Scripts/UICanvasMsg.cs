using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasMsg : MonoBehaviour
{
    public UICanvasMsg_SO uICanvasMsg_SO;

    public float tweenTime;

    public Text msgText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (uICanvasMsg_SO.canDisplayCommunication)
        {
            TweenMsg(uICanvasMsg_SO.communicationText);
            uICanvasMsg_SO.canDisplayCommunication = false;
        }
    }

    public void TweenMsg(string msg)
    {
        LeanTween.cancel(msgText.gameObject);

        msgText.gameObject.SetActive(true);
        msgText.text = msg;
        //LeanTween.alpha(msgText.gameObject, 1f, 1f);
        LeanTween.scale(msgText.gameObject, Vector3.one /2, tweenTime).setEasePunch().setOnComplete(HideUI);
        //msgText.gameObject.SetActive(false);
    }

    public void HideUI()
    {
        msgText.gameObject.SetActive(false);
    }
}
