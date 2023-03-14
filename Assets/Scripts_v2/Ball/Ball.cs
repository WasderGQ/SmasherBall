using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private int _id;
    

    public void GiveBallToID(Ball[] balls)
    {
       _id = balls.Count();
      
    }






}

   