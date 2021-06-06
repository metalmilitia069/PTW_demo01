using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisControlTrigger : MonoBehaviour
{
    [SerializeField]
    private float _speed = 15;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("mozovos");
        if (other.GetComponent<BeginWall>())
        {
            other.GetComponent<BeginWall>().endWall.GetComponent<EndWall>().KillMode = true;
        }
        else if (other.GetComponent<EndWall>())
        {
            other.GetComponent<EndWall>().KillMode = false;
        }

    }

    public void Move()
    {
        this.transform.position += new Vector3(0, 0, (_speed * Time.deltaTime * -1));
    }
}
