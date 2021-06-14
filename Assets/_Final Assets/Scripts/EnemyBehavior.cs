using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : EnemyCombat
{
    public GameManager_SO gameManager_SO;

    private ShipBase player;
    public ShipBase player1;

    [SerializeField]
    private float _minDist;
    [SerializeField]
    private float _maxDist;
    private float _randomDist;
    private float _enemyZCoord;
    private Vector3 _direction;
    [SerializeField]
    private float angleOfView;
    [SerializeField]
    private float _maxAngleOfView;

    private string state = "Running";

    private enum AIStateMachine
    {
        Idle,
        Moving,
        Attacking,
        Steering
    }

    [SerializeField]
    private AIStateMachine _aiState = AIStateMachine.Moving;

    [SerializeField]
    private float Backbound;
    [SerializeField]
    private float Forwardbound;
    [SerializeField]
    private float Leftbound;
    [SerializeField]
    private float Rightbound;

    private int _steeringSide;

    // Start is called before the first frame update
    void Start()
    {
        player = gameManager_SO.shipBase;
        _randomDist = Random.Range(_minDist, _maxDist);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Move();

        _enemyZCoord = this.gameObject.transform.position.z;

        _direction = player.gameObject.transform.position - this.gameObject.transform.position;
        
        angleOfView = Vector3.Angle(_direction, Vector3.back);


        

        if (angleOfView < _maxAngleOfView)
        {
            //if (_aiState != AIStateMachine.Steering)
            //{
                
            //}

            Debug.Log("I See You!!!");
        }
        else
        {
            Debug.Log("Where are you??");
        }

    }

    public void Steering()
    {
        //this.transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
        Random.Range(0, 2);
    }

}
