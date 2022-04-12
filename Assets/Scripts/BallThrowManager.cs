using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrowManager : MonoBehaviour
{
    private GameObject _targetSight;
    private GameObject _clonearrow;
    private Transform _canvas;
    private Rigidbody2D ball;

    private void Awake()
    {
        GameManager.ballThrowManager = this;
        _targetSight = Resources.Load<GameObject>("Prefabs/TargetSight");
        _canvas = GameObject.Find("Canvas").transform;
        ball = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InstantiateArrowOnScene();
    }


    void InstantiateArrowOnScene()
    {

        if (GameManager.controllerManager._IsPressedMouse == true && _clonearrow == null && GameManager.controllerManager.SecondMousePosition.x != 0  )
        {
           _clonearrow=Instantiate<GameObject>(_targetSight, GameManager.controllerManager.FirstMousePosition, Quaternion.Euler(0,0,GameManager.math.ReversinputsLocationLine.w),_canvas);
            
           // Debug.Log("Arrow Spawnlandý");
        }
        if(GameManager.controllerManager._IsPressedMouse == true && GameManager.math.ReversinputsLocationLine.y >= 0)
        {
            _clonearrow.transform.rotation = Quaternion.Euler(0f, 0f, GameManager.math.ReversinputsLocationLine.w);


        }
        if (GameManager.controllerManager._IsPressedMouse == false)
        {
            Destroy(_clonearrow);

        }

    }

    public void throwaball()
    {


        ball.velocity = GameManager.targetAimManager.TargetAimPosition / 100;

    }




}
