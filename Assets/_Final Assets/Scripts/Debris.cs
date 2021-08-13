using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    [SerializeField]
    protected float _speed = 15;
    [SerializeField]
    protected bool _isRotating;
    [SerializeField]
    protected float _rotationSpeed = 5;

    protected int _randomRotation;
    protected int _randomRotation2;

    public SelectDebris selectDebris;

    //public DebrisType debrisType;

    // Start is called before the first frame update
    void Start()
    {
        _randomRotation = Random.Range(0, 2);
        _randomRotation2 = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (_isRotating)
        {
            RotateThis();
        }
    }

    public void Move()
    {
        this.transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
    }

    public void RotateThis()
    {
        if (_randomRotation == 0)
        {
            this.transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
        }
        else
        {
            this.transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime * -1);
        }
        //this.transform.rotation += Quaternion.AngleAxis(10, Vector3.forward * _speed * Time.deltaTime);
    }

}

[System.Serializable]
public struct SelectDebris
{    
    public enum DebrisType
    {
        standard,        
        asteroid,
        metalSmall
    }

    public DebrisType debrisType;
}
  
