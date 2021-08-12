using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFragment : MonoBehaviour
{
    public Vector3 lala;

    public ParticleSystem particleSystem;

    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(Random.Range(125f, 750f), this.transform.position, radius);


        particleSystem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
