using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTesting : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public GameObject aiController;
    public float speed;
    private float x;
    private float y;
   
    //public CheckCollision collision;

    // Start is called before the first frame update
    void Start()
    {
        // collision.GetComponent<CheckCollision>();
        
        myRigidbody2D.GetComponent<Rigidbody2D>();
        BallMovement();

    }
  /*  private void LateUpdate()
    {
        if(aiController.GetComponent<ComputerPlayer>().speed == 10f)
        {
            this.speed += 50f;
            myRigidbody2D.AddForce(new Vector2(x, y) * this.speed);
        }
        
    }*/

    void BallMovement()
    {
         x = Random.value < 0.5f ? -1.0f : 1.0f;
         y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        myRigidbody2D.AddForce(new Vector2(x, y) * speed);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == aiController)
        {
            aiController.GetComponent<ComputerPlayer>().speed = 10f;
        }
    }



    /* void PlayerMovement()
     {
         if (Input.GetKey(KeyCode.D))
         {
             // myRigidbody2D.velocity = Vector2.right * Time.deltaTime * 10;
             transform.Translate(Vector2.right * Time.deltaTime * 10);
         }
         if (Input.GetKey(KeyCode.A))
         {
             //myRigidbody2D.velocity = Vector2.up * 10;
             transform.Translate(-Vector2.right * Time.deltaTime * 10);
         }


         if (Input.GetKey(KeyCode.Space))
         {
             if (collision.isGround == true)
             {
                 myRigidbody2D.velocity = Vector2.up * jump;

             }
             collision.isGround = false;

         }
     }*/
}
