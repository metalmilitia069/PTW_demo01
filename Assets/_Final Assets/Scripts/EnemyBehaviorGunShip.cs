using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorGunShip : EnemyCombat
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
    [SerializeField]
    private float topbound;
    [SerializeField]
    private float bottombound;

    private int _steeringSide;
    private int _steeringPitch;
    private bool _canSteer;

    public enum SteerringView
    {
        onTopView,
        onSideView,
        onBackView
    }

    public SteerringView pickSteerringView;


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

        if (player)
        {
            _direction = player.gameObject.transform.position - this.gameObject.transform.position;

            angleOfView = Vector3.Angle(_direction, Vector3.back);
        }

        if (this.transform.position.z < _randomDist)
        {
            _aiState = AIStateMachine.Attacking;
            //Debug.Log("AI IS ATTACKING");
        }

        Move();

        //if (_aiState == AIStateMachine.Moving)
        //{
        //    Move();
        //}

        if (_aiState == AIStateMachine.Attacking)
        {
            StartAttack();
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
        if (pickSteerringView == SteerringView.onTopView)
        {
            SteerTopView();
        }
        else if (pickSteerringView == SteerringView.onSideView)
        {
            SteerSideView();
        }
        else
        {
            SteerTopView();
            SteerSideView();
        }
    }

    public void SteerTopView()
    {
        if (this.transform.position.x < Leftbound)
        {
            _steeringSide = 1;
        }
        else if (this.transform.position.x > Rightbound)
        {
            _steeringSide = 0;
        }

        if (_steeringSide == 0)
        {
            this.transform.position -= new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            this.transform.position += new Vector3(manouverSpeed * Time.deltaTime, 0, 0);
        }

    }

    public void SteerSideView()
    {
        if (this.transform.position.y < bottombound)
        {
            _steeringPitch = 1;
        }
        else if (this.transform.position.y > topbound)
        {
            _steeringPitch = 0;
        }

        if (_steeringPitch == 0)
        {
            this.transform.position -= new Vector3(0, manouverSpeed * Time.deltaTime, 0);
        }
        else
        {
            this.transform.position += new Vector3(0, manouverSpeed * Time.deltaTime, 0);
        }
    }

    public void StartAttack()
    {
        if (Time.time > timeToShoot)
        {
            AttackPlayer();
            timeToShoot = Time.time + fireRate;
        }
    }
}
