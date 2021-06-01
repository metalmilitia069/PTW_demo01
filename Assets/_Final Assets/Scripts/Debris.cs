using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    [SerializeField]
    private float _speed = 15;
    [SerializeField]
    private bool _isRotating;
    [SerializeField]
    private float _rotationSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
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
        //this.transform.rotation += Quaternion.AngleAxis(10, Vector3.forward * _speed * Time.deltaTime);
        this.transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
    }


}
