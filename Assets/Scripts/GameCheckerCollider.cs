using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCheckerCollider : MonoBehaviour
{
    public bool IsReadyToThrow;
    private int HowMuchBallHoldingInsideGameCheckerCollider;
    public Transform FirstBallLocationOnGameCheckerCollider;
    public Collision2D OnCollisionEnterObject;
    
    private void Awake()
    {
        VariableManager.gameCheckerCollider = this;
        IsReadyToThrow = true;
        
    }
    private void Update()
    {
        IsReadyToThrowABallChecker();
    }

    //cisim ilk �arp�t��� anda
    private void OnCollisionEnter2D(Collision2D collision)
    {
        


        if (collision.gameObject.tag == "Ball")
        {

            OnCollisionEnterObject = collision;
            HowMuchBallHoldingInsideGameCheckerCollider++;
           // collision.gameObject.GetComponent<Ball>().AmIHitTheGameCheckerCollider = true;
            FirstBallPositionChecker();
            BallStopper();
            DestroyCloneBalls();




        }
        
    
    
    
    }

    
    
    
    
    //cisim �arp��maya devam etti�i s�rece
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            

        }
    }




    //cisim �arpmay� b�rakt��� anda
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
       // collision.gameObject.GetComponent<Ball>().AmIHitTheGameCheckerCollider = false;
        HowMuchBallHoldingInsideGameCheckerCollider--;


            






        }
        
     





    }





    //uygulanan olaylar�n metodlar�

    void IsReadyToThrowABallChecker()
    {
        if (VariableManager.gameManager.TempLevelHolder == HowMuchBallHoldingInsideGameCheckerCollider)
        {
            IsReadyToThrow = true;
            

        }

        else
        {


            IsReadyToThrow = false;

        }





    }

    
    void FirstBallPositionChecker()
    {
      /*  if (OnCollisionEnterObject.gameObject.GetComponent<Ball>().ID == 0)
        {
            FirstBallLocationOnGameCheckerCollider = OnCollisionEnterObject.transform;
            
           
        }
      */

    }


    void BallStopper()
    {

        OnCollisionEnterObject.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

    }

 
    void DestroyCloneBalls()
    {

       /* if (OnCollisionEnterObject.gameObject.GetComponent<Ball>().ID > 0)
        {
            Destroy(OnCollisionEnterObject.gameObject);


        }
       */
    }



}
