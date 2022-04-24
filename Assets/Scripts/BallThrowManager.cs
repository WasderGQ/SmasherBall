using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrowManager : MonoBehaviour
{
    private void Awake()
    {
        VariableManager.ballThrowManager = this;
    }

    private void Update()
    {
        
    }

    public void FirstBallThrow()
    {
        if (VariableManager.gameCheckerCollider.IsReadyToThrow == true)
        {
        VariableManager.ballManager.RDBall[0].velocity = VariableManager.math.VelocityUnitVector * VariableManager.gameManager.ThrowSpeed;
        }
           
    }
    
    
    
    
    
    
    
    public void ThrowABall()
    {      
                   VariableManager.ballManager.RDBall[VariableManager.ballManager.CloneBallArrayIndex].velocity = VariableManager.math.VelocityUnitVector * VariableManager.gameManager.ThrowSpeed;
    }

  
       
        
    }


   

