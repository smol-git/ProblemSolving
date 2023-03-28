using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPlayer : MonoBehaviour
{
    Transform CurrentTransform;
    public Rigidbody2D Ball;
    public Rigidbody2D myRigidbody2D;
    public float lerpSpeed = 10f;
    public float offset;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D.GetComponent<Rigidbody2D>();
        CurrentTransform = this.transform;
       // myRigidbody2D.AddForce(Vector2.up * speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TestingAIPaddleWithoutLerp();

    }

    void AIPaddleUpDownMovement()
    {
        if (transform.position.y >= offset)
        {
            myRigidbody2D.AddForce(Vector2.down * speed);
        }
        if (transform.position.y <= -offset)
        {
            myRigidbody2D.AddForce(Vector2.up * speed);
        }
    }

    void TestingAIPaddleWithLerp()
    {
        if (Ball.transform.position.y > transform.position.y)
        {
            if (myRigidbody2D.velocity.y < 0)
            {
                myRigidbody2D.velocity = Vector2.zero;
            }
            myRigidbody2D.velocity = Vector2.Lerp(myRigidbody2D.velocity, Vector2.up * speed, lerpSpeed * Time.deltaTime);

        }
        else if (Ball.transform.position.y < transform.position.y)
        {
            if (myRigidbody2D.velocity.y > 0)
            {
                myRigidbody2D.velocity = Vector2.zero;               
            }
            myRigidbody2D.velocity = Vector2.Lerp(myRigidbody2D.velocity, Vector2.down * speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            myRigidbody2D.velocity = Vector2.Lerp(myRigidbody2D.velocity, Vector2.zero * speed, lerpSpeed * Time.deltaTime);
        }
    }

    void TestingAIPaddleWithoutLerp()
    {
        CurrentTransform = this.transform;

        if (Ball.velocity.x > 0.0f)
        {
            if (CurrentTransform.position.y < Ball.transform.position.y)
            {
                myRigidbody2D.AddForce(Vector2.up * speed);
            }
            else if (CurrentTransform.position.y > Ball.transform.position.y)
            {
                myRigidbody2D.AddForce(Vector2.down * speed);
            }
        else
        {
                if (CurrentTransform.position.y > 0.0f)
                {
                    myRigidbody2D.AddForce(Vector2.down * speed);
                }
                else if (CurrentTransform.position.y < 0.0f)
                {
                    myRigidbody2D.AddForce(Vector2.up * speed);
                }

            }

        }
    }
}
