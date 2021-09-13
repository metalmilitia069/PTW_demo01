using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortressDebrisPartTwo : Debris
{
    public FortressDebris_SO fortressDebris_SO;
    public CutSceneManager_SO cutSceneManager_SO;

    [SerializeField]
    private GameObject _animationProp;


    // Start is called before the first frame update
    void Awake()
    {
        _randomRotation = Random.Range(0, 2);
        _randomRotation2 = Random.Range(0, 3);
        cutSceneManager_SO.FortressDebrisPartTwoRef = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (fortressDebris_SO.PartTwoCanMove)
        {
            Move();
            //Debug.Log("Position Z: " + this.transform.position.z);
            //Debug.Log("mozoooo");
            if (_isRotating)
            {
                RotateThis();
            }
        }
    }

    private void LateUpdate()
    {
        if (fortressDebris_SO.PartTwoEnabled)
        {
            _animationProp.gameObject.SetActive(true);
        }
    }
}
