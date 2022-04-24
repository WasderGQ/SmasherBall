using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ControllerManager : MonoBehaviour
{
    //Touch _touch; touch mekaniðini mousede çalýþtýramadým bu yüzden vazgeçtim
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
        if(Input.GetMouseButtonDown(0) && IsMouseOnGameObject) // tuþa bastýðýnda
        {
            FirstMousePosition = Input.mousePosition;
            IsPressedMouse = true;
            VariableManager.targetAimManager.InstantiateAimTarget();
        }

        if(Input.GetMouseButtonUp(0) && IsMouseOnGameObject) //tuþtan elini kaldýrdýðýnda
        {
            IsPressedMouse = false;
            VariableManager.targetAimManager.DestroyAimTarget();
            VariableManager.math.FindAimAngleUnitVector();
            VariableManager.ballThrowManager.FirstBallThrow();

        }

        if(IsPressedMouse == true)//basýlý tutulduðu sürece
        {
            SecondMousePosition = Input.mousePosition;
            VariableManager.math.FindAngleBetweenTwoPoints();
            VariableManager.targetAimManager.RefreshAimAngle();
        }

    }

    void MouseOnUIChecker()//UI üzerinde ise maouse hareketlerini çalýþtýrma
    {

        IsMouseOnGameObject = EventSystem.current.currentSelectedGameObject == null;
       
    }










   

}



