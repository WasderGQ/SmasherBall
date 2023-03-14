using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSettings : MonoBehaviour
{
    int asd;
    // Start is called before the first frame update
    void Awake()
    {
        TargetFrameSet();
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void TargetFrameSet()
    {
       switch(Screen.currentResolution.refreshRate)

        {
            case 30:
                Application.targetFrameRate = 30;
                break;
            case 60:
                Application.targetFrameRate = 60; 
                break;
            case 90:
                Application.targetFrameRate = 90;
                break;
            case 120:
                Application.targetFrameRate = 120;
                break;
            case 240:
                Application.targetFrameRate = 240;
                break;
            case 360:
                Application.targetFrameRate = 360;
                break;
            default:
                Application.targetFrameRate = 60;
                break;







        }




    }



}
