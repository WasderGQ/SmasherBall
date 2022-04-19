using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

   

public class MenuManager : MonoBehaviour
{

     Text Leveltext;
   
        


    void Start()
    {
        Leveltext = GameObject.Find("Level").GetComponent<Text>();
    }

    
    void Update()
    {
        LevelTextChanger();
    }




    public void RestartButtonOnCanvas()
    {
        SceneManager.LoadScene(0);
      


    }

    public void LevelTextChanger()
    {

        Leveltext.text = VariableManager.gameManager.TempLevelHolder.ToString();



    }
}
