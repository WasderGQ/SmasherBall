using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool AmIHitTheGameCheckerCollider;
    public int ID;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GameCheckerCollider")
        {
            AmIHitTheGameCheckerCollider = true;

        }
    }

    
}
