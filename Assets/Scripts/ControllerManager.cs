using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ControllerManager : MonoBehaviour
{
    //Touch _touch; touch mekani�ini mousede �al��t�ramad�m bu y�zden vazge�tim
    public Vector3 FirstMousePosition;
    public Vector3 SecondMousePosition;
    public bool IsPressedMouse;
    private bool IsMouseOnGameObject;
    
    private void Awake()
    {
      VariableManager.controllerManager = this;
    }

    void Start()
    {
       
        
    }


    void Update()
    {
        MousePositionFinderAndClickChecker();
        MouseOnUIChecker();



    }




    void MousePositionFinderAndClickChecker()
    {
        if(Input.GetMouseButtonDown(0) && IsMouseOnGameObject) // tu�a bast���nda
        {
            FirstMousePosition = Input.mousePosition;
            IsPressedMouse = true;
            VariableManager.targetAimManager.InstantiateAimTarget();
        }

        if(Input.GetMouseButtonUp(0) && IsMouseOnGameObject) //tu�tan elini kald�rd���nda
        {
            IsPressedMouse = false;
            VariableManager.targetAimManager.DestroyAimTarget();
            VariableManager.math.FindAimAngleUnitVector();
            VariableManager.ballThrowManager.FirstBallThrow();

        }

        if(IsPressedMouse == true)//bas�l� tutuldu�u s�rece
        {
            SecondMousePosition = Input.mousePosition;
            VariableManager.math.FindAngleBetweenTwoPoints();
            VariableManager.targetAimManager.RefreshAimAngle();
        }

    }

    void MouseOnUIChecker()//UI �zerinde ise maouse hareketlerini �al��t�rma
    {

        IsMouseOnGameObject = EventSystem.current.currentSelectedGameObject == null;
       
    }










   

}



