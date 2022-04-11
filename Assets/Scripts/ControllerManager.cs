using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    Touch _touch;
    GameObject testobject;
    Vector3 FirstMousePosition;
    Vector3 SecondMousePosition;

    void Start()
    {
        testobject = GameObject.Find("TestGameObject");
        Input.simulateMouseWithTouches = true;
    }


    void Update()
    {
        MousePositionFinder();
    }






    void MousePositionFinder()
    {
        if(Input.GetMouseButtonDown(0))
        {
            FirstMousePosition = Input.mousePosition;
            Debug.Log(FirstMousePosition);


        }





    }












    void TouchPositionFinder()
    {
    if (Input.touchCount > 0)
        {
        testobject.SetActive(true);
        _touch = Input.GetTouch(0);
        Debug.Log(_touch.rawPosition);
        }
    else
         {
        testobject.SetActive(false);


         }



    }



}



