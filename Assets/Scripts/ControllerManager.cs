using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ControllerManager : MonoBehaviour
{
    //Touch _touch; touch mekaniðini mousede çalýþtýramadým bu yüzden vazgeçtim
    public Vector3 FirstMousePosition;
    public Vector3 SecondMousePosition;
    public bool _IsPressedMouse;
    private bool IsMouseOnGameObject;
    private void Awake()
    {
      GameManager.controllerManager = this;
    }

    void Start()
    {
       
        
    }


    void Update()
    {
        MousePositionFinder();
        MouseOnUIChecker();



    }




    void MousePositionFinder()
    {
        if (Input.GetMouseButtonDown(0) && IsMouseOnGameObject)
        {
            FirstMousePosition = Input.mousePosition;
            _IsPressedMouse = true;
            //Debug.Log(FirstMousePosition);
        }

        if (Input.GetMouseButtonUp(0) && IsMouseOnGameObject)
        {
            _IsPressedMouse = false;
            GameManager.ballThrowManager.throwaball();


        }

        if(_IsPressedMouse == true)
        {
            SecondMousePosition = Input.mousePosition;
            GameManager.math.FindSightDirection();
            //Debug.Log(SecondMousePosition);
           // Debug.Log(GameManager.math.ReversinputsLocationLine);
        }

    }

    void MouseOnUIChecker()
    {

        IsMouseOnGameObject = EventSystem.current.currentSelectedGameObject == null;
        Debug.Log(IsMouseOnGameObject);
    }










   /* void TouchPositionFinder()
    {
    if (Input.touchCount > 0)
        {
        testobject.SetActive(true);
        _touch = Input.GetTouch(0);
       
        }
    else
         {
        testobject.SetActive(false);


         }



    }
   *///bu sistemi kullanamadým daha sonra öðrenirim belki !!!!


}



