using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour
{
    public Vector4 VectorBetwenTwoPoint;
    public Vector2 VelocityUnitVector;
    private float RadiusToAngle = 180 / 3.14159265358979323846f;
    private float AngleBetweenTwoPoints;
    private float AngleToRadius = 3.14159265358979323846f / 180;


    private void Awake()
    {
        
        
        VariableManager.math = this;
    }



    public void FindAngleBetweenTwoPoints()
    {
        

       

             if (VariableManager.controllerManager.FirstMousePosition.y > VariableManager.controllerManager.SecondMousePosition.y)
            {
                VectorBetwenTwoPoint.x = VariableManager.controllerManager.FirstMousePosition.x - VariableManager.controllerManager.SecondMousePosition.x;
                VectorBetwenTwoPoint.y = VariableManager.controllerManager.FirstMousePosition.y - VariableManager.controllerManager.SecondMousePosition.y;
                AngleBetweenTwoPoints = Mathf.Atan(VectorBetwenTwoPoint.x / VectorBetwenTwoPoint.y) * RadiusToAngle;


                if (AngleBetweenTwoPoints < 0)
                {

                    AngleBetweenTwoPoints = AngleBetweenTwoPoints + 90;
                    AngleBetweenTwoPoints = 180 - AngleBetweenTwoPoints;
                }
                else if (AngleBetweenTwoPoints > 0)
                {

                    AngleBetweenTwoPoints = 90 - AngleBetweenTwoPoints;

                }
                else if (AngleBetweenTwoPoints == 0)
                {
                    AngleBetweenTwoPoints = 90;
                }

                VectorBetwenTwoPoint.z = 0;
                VectorBetwenTwoPoint.w = AngleBetweenTwoPoints;

                

            }



       
    }






    public void FindAimAngleUnitVector()
    {
        
            VelocityUnitVector.y = Mathf.Sin(AngleBetweenTwoPoints * AngleToRadius);
            VelocityUnitVector.x = Mathf.Cos(AngleBetweenTwoPoints * AngleToRadius);
 

    }
            
            
            
            
    public int RandomNumber(int Minvalue, int Maxvalue)
    {
        int tempvalue = Random.Range(Minvalue, Maxvalue);
        return tempvalue;



    }


   


}
