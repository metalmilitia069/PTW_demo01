using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player/Stats")]
public class ShipStats_SO : ScriptableObject
{
    public float playerHealth = 0;
    public float playerSpeed = 0;
    public float fireRate = 0;


    public void ResetPlayerData()
    {
        playerHealth = 0;
        playerSpeed = 0;
        fireRate = 0;
    }

}
