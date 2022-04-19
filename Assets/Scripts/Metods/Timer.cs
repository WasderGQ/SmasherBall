using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool IsTimerOver;
    public bool AmIStart;
    private float TimeHolder;
    private float WaitSecond = 0.02f;
    // Start is called before the first frame update
    void Awake()
    {
        VariableManager.timer = this;
    }

    // Update is called once per frame
    void Update()
    {
        WaitAForNextBallMove();
    }


    public void WaitAForNextBallMove()
    {
        if (AmIStart)
        {
            TimeHolder = +Time.deltaTime;

            if (TimeHolder >= WaitSecond)
            {
                TimeHolder = 0;
                IsTimerOver = true;
            }

        }

        AmIStart = false;
    }

}
