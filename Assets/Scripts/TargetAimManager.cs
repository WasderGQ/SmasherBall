using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAimManager : MonoBehaviour
{
    GameObject ball;
    public Vector3 TargetAimPosition;
    private void Awake()
    {
        GameManager.targetAimManager = this;
        ball = GameObject.Find("Ball");

    }



    private void Update()
    {
        refreshtotargetaim();


    }


void refreshtotargetaim()
    {

        if (GameManager.math.ReversinputsLocationLine.y >= 0)
        {
            TargetAimPosition = new Vector3(GameManager.math.ReversinputsLocationLine.x + ball.transform.position.x, GameManager.math.ReversinputsLocationLine.y + ball.transform.position.y, GameManager.math.ReversinputsLocationLine.z);
            this.gameObject.transform.position = TargetAimPosition;

        }

    }





}

