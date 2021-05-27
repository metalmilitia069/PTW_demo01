using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnManagerPoll", menuName = "Managers/Spawner")]
public class SpawnManager_SO : ScriptableObject
{
    [Header("something")]
    public int number;
    //public WaveConfig[] waveConfig;

    //public class WaveConfig
    //{
    //    public int numberOfEnemies;
    //    public GameObject enemyType;
    //}

    //public WaveConfig[] waves = new WaveConfig[1];

    public mozo[] teucu;
}

[System.Serializable]
public struct mozo
{
    public int mozoa;
    public int alala;
    public GameObject prefab;
}


