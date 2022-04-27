using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool AmIHitTheGameCheckerCollider;
    public int ID;
    private Collider2D MyCollider;
    private void Awake()
    {
        MyCollider = this.gameObject.GetComponent<Collider2D>();
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GameCheckerCollider")
        {
            AmIHitTheGameCheckerCollider = true;

        }
        if (collision.gameObject.tag == "Ball")
        {
            Physics2D.IgnoreCollision(MyCollider, collision.collider);


        }
    }
}

   