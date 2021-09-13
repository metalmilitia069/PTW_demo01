using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerRod : MonoBehaviour
{
    public GameObject powerRod;
    public GameObject brokenRod;
    public GameObject wires;

    [SerializeField]
    private int rodHP = 10;

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
        if (other.GetComponent<ProjectileBase>())
        {
            TakeDamage();
            Destroy(other.gameObject);
        }
    }

    private void TakeDamage()
    {
        rodHP--;
        if (rodHP <= 0)
        {
            Explode();
        }
    }

    private void Explode()
    {
        powerRod.gameObject.SetActive(false);
        brokenRod.gameObject.SetActive(true);
        wires.gameObject.SetActive(true);
        Destroy(this.gameObject, 10.0f);
    }


}
