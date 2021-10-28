using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "UICanvasMsg_SO", menuName = "UI/CanvasMsg")]
public class UICanvasMsg_SO : ScriptableObject
{
    public string communicationText = default;
    public bool canDisplayCommunication = false;

    private void OnDisable()
    {
        communicationText = default;
    }
}
