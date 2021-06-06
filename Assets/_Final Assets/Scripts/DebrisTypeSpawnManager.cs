using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisTypeSpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] TopViewSpawnPoints;
    [SerializeField]
    private GameObject[] SideViewSpawnPoints;
    [SerializeField]
    private GameObject[] BackViewSpawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnTopViewDebrisType()
    {

        float aboveXCoords = Random.Range(TopViewSpawnPoints[0].transform.position.x, TopViewSpawnPoints[1].transform.position.x);
        float aboveYCoords = Random.Range(TopViewSpawnPoints[0].transform.position.y, TopViewSpawnPoints[2].transform.position.y);

        float belowXCoords = Random.Range(TopViewSpawnPoints[3].transform.position.x, TopViewSpawnPoints[4].transform.position.x);
        float belowYCoords = Random.Range(TopViewSpawnPoints[3].transform.position.x, TopViewSpawnPoints[5].transform.position.x);

        

        yield return new WaitForSeconds(0.1f);
    }

}
