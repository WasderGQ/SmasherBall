using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrowManager : MonoBehaviour
{
    private void Awake()
    {
        VariableManager.ballThrowManager = this;
    }


    public void ThrowABall()
    {
       
        
        if(VariableManager.gameCheckerCollider.IsReadyToThrow == true)
        {

            for (int index = 0; index <= VariableManager.ballManager.CloneBallArrayIndex; index++)
            {
                if (VariableManager.ballManager.RDBall[index] != null)
                {

                    VariableManager.ballManager.RDBall[index].velocity = VariableManager.math.VelocityUnitVector * VariableManager.gameManager.ThrowSpeed;
                    VariableManager.timer.AmIStart = true;
                    if(VariableManager.timer.IsTimerOver == true)
                    {
                        VariableManager.ballManager.BallIntantiate(VariableManager.gameCheckerCollider.FirstBallLocationOnGameCheckerCollider.position);

                    }
                }

            }

        }

  
       
        
    }


   
}
