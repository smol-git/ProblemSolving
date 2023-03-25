using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTesting : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float speed;
   
    //public CheckCollision collision;

    // Start is called before the first frame update
    void Start()
    {
       // collision.GetComponent<CheckCollision>();
         myRigidbody2D.GetComponent<Rigidbody2D>();
        BallMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BallMovement()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        myRigidbody2D.AddForce(new Vector2(x, y) * speed);


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
