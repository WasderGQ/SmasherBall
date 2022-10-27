using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrowManager : MonoBehaviour
{
    public bool CanIThrowCloneBalls;
    private void Awake()
    {
        VariableManager.ballThrowManager = this;
    }

    private void Update()
    {
        
    }

    public void ThrowFirstBall()
    {
        if (VariableManager.gameCheckerCollider.IsReadyToThrow == true)
        {
            VariableManager.ballManager.RDBall[0].velocity = VariableManager.math.VelocityUnitVector * VariableManager.gameManager.ThrowSpeed ;
            CanIThrowCloneBalls = true;
        }
           
    }
    
    
    public void OtoThrowBall()
    {
        if(CanIThrowCloneBalls)
        {
            if(VariableManager.ballManager.CanIThrowNextBall)
            {
                VariableManager.ballManager.BallSpawn(VariableManager.gameCheckerCollider.FirstBallLocationOnGameCheckerCollider.position);

                SingleBallThrow();



            }


        }




    }
    
    public void SingleBallThrow()
    {

        VariableManager.ballManager.RDBall[VariableManager.ballManager.CloneBallArrayIndex].velocity = VariableManager.math.VelocityUnitVector * VariableManager.gameManager.ThrowSpeed;
        

    }
    
    
    

  
       
        
    }


   

