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
    }
    private void Start()
    {
      TempLevelHolder = VariableManager.valueHolder.Level;
    }





    public void LevelUpCounter()
    {

        

            TempLevelHolder++;

        

    }
}
