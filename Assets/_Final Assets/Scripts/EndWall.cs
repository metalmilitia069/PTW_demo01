using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWall : MonoBehaviour
{
    [SerializeField]
    private GameObject beginWall;

    private bool _killMode;

    public bool KillMode { get => _killMode; set => _killMode = value; }




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
        if (!_killMode)
        {
            other.transform.position = beginWall.transform.position;
        }
        else
        {
            Destroy(other.gameObject, 5);
        }
    }    
}
