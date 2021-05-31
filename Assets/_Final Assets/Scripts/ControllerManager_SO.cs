using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Controller", menuName = "Managers/Controller")]
public class ControllerManager_SO : ScriptableObject
{
    [Range(-1, 2)]
    public int controlSwitcher = -1;
    
}
