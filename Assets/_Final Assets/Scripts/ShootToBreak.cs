using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToBreak : MonoBehaviour
{
    public GameObject wholeItem;
    public GameObject brokenItem;

    public int itemHP = 10;
    public float timeToDestroy = 10.0f;

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
        itemHP--;

        if (itemHP <= 0)
        {
            Explode();
        }
    }

    private void Explode()
    {
        wholeItem.gameObject.SetActive(false);
        brokenItem.gameObject.SetActive(true);

        Destroy(this.gameObject, timeToDestroy);
    }
}
