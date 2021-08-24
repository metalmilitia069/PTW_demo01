using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaDebrisEndWall : MonoBehaviour
{
    public SeaDebrisEndWall_SO seaDebrisEndWall_SO;

    public GameObject startLocation;
    [SerializeField]


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SeaDebris>())
        {
            if (seaDebrisEndWall_SO.isKillingSeaDebris && other.GetComponent<SeaDebris>().selectDebris.debrisType == SelectDebris.DebrisType.seaDebris)
            {
                Destroy(other.gameObject);
                return;
            }            
            else
            {
                other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, startLocation.transform.position.z);
            }
        }
        else if (other.GetComponent<ShipStats>())
        {
            other.GetComponent<ShipStats>().TakeDamage();
        }
    }
}
