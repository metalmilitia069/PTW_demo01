using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaDebris : Debris
{
    [SerializeField]
    private bool isFloating;

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

        if (isFloating)
        {
            Floating();
            FloatingBOuncing();
        }


    }

    public int negative = -1;

    public void Floating()
    {
        if (this.transform.localEulerAngles.x >= 331.0f && this.transform.localEulerAngles.x <= 341.0f) // || this.transform.rotation.x > -38.0f)
        {
            negative = 1;
            Debug.Log("cu");
        }
        else if (this.transform.localEulerAngles.x <= 18.0f && this.transform.localEulerAngles.x >= -8.0f)
        {
            Debug.Log("laalal");
            negative = -1;
        }
        //Debug.Log(this.transform.localEulerAngles.x);
        //this.transform.Rotate(new Vector3(negative, 0, 0), (5.0f) * Time.deltaTime);

        Debug.Log(this.transform.localEulerAngles.z);

        if (this.transform.localEulerAngles.z >= 309.0f && this.transform.localEulerAngles.z <= 316.0f) // || this.transform.rotation.x > -38.0f)
        {
            negative = 1;
            Debug.Log("cu");
        }
        else if (this.transform.localEulerAngles.z <= 30.0f && this.transform.localEulerAngles.z >= 20.0f)
        {
            Debug.Log("laalal");
            negative = -1;
        }
        
        this.transform.Rotate(new Vector3(negative, 0, negative), (5.0f) * Time.deltaTime);
    }

    public void FloatingBOuncing()
    {
        this.transform.position = new Vector3(this.transform.position.x, (Mathf.Lerp(this.transform.position.y + 5, this.transform.position.y - 5, this.transform.position.y) * Time.deltaTime), this.transform.position.z);
    }
}
