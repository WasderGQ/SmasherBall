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

    private void Update()
    {
        randomthrow();
    }

    void randomthrow()
    {
        if(Input.GetKeyDown(KeyCode.W)) 
        { 
        
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(100f,100f);
        
        
        }



    }


}

   