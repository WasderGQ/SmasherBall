using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour
{
    public Vector4 ReversinputsLocationLine;
    public Vector4 InputsLocationLine;
    
    private void Awake()
    {
        GameManager.math = this;
    }

    public void FindSightDirection()
    {

       




        ReversinputsLocationLine.x = GameManager.controllerManager.FirstMousePosition.x - GameManager.controllerManager.SecondMousePosition.x; 
        ReversinputsLocationLine.y = GameManager.controllerManager.FirstMousePosition.y - GameManager.controllerManager.SecondMousePosition.y;
        float Newvectorlenght = Mathf.Sqrt(ReversinputsLocationLine.x * ReversinputsLocationLine.x + ReversinputsLocationLine.y * ReversinputsLocationLine.y) ;
        ReversinputsLocationLine.w = Mathf.Acos(ReversinputsLocationLine.x / Newvectorlenght) * 57.2957795f;
        InputsLocationLine.x = ReversinputsLocationLine.x * -1;
        InputsLocationLine.y = ReversinputsLocationLine.y * -1;



    }






}
