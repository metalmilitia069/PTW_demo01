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
    private bool _canSteer;


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

        if (_aiState == AIStateMachine.Moving)
        {
            Move();
        }

        if (this.transform.position.z < _randomDist)
        {
            _aiState = AIStateMachine.Attacking;
            Debug.Log("AI IS ATTACKING");
        }
        

        if (angleOfView < _maxAngleOfView && _aiState != AIStateMachine.Moving)
        {            
            if (_canSteer)
            {
                _steeringSide = Random.Range(0, 2);
                _canSteer = false;
            }
            Steering();
            //Debug.Log("I See You!!!");
        }
        else
        {
            _canSteer = true;
            //Debug.Log("Where are you??");
        }

    }

    public void Steering()
    {
        //this.transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
        if (_steeringSide == 0)
        {
            this.transform.position -= new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            this.transform.position += new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
        }

        if (this.transform.position.x < Leftbound)
        {
            _steeringSide = 1;
        }
        else if (this.transform.position.x > Rightbound)
        {
            _steeringSide = 0;
        }
    }

}
