using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.Profiling;

   

public class MenuManager : MonoBehaviour
{

     Text Leveltext;
    public GameObject StatsText;
    Profilling StatsProfil;   


    void Start()
    {
        StatsProfil = GameObject.Find("Main Camera").GetComponent<Profilling>() ;
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

    public void StatsActive()
    {
        if (StatsProfil.isActiveAndEnabled == true)
        {
            StatsProfil.enabled = false;
            StatsText.SetActive(false);

        }
        else
        {
            StatsProfil.enabled = true;
            StatsText.SetActive(true);
        }


    }
}
