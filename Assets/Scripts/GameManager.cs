using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int TempLevelHolder;
    public int ThrowSpeed;
    
    
    
    private void Awake()
    {
        VariableManager.gameManager = this;
      
        
    } void Start()
    {
        LevelCounterFixer();

     //
     //TempLevelHolder = VariableManager.valueHolder.Level;
    }





    public void LevelUpCounter()
    {

        

            TempLevelHolder++;

        

    }

    public void LevelCounterFixer()
    {
        if(TempLevelHolder == 0)
        {
            TempLevelHolder = 1;

        }



    }


}
