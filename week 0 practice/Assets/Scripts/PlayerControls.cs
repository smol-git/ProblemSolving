using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float playerOffset;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(transform.position.x, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate(Vector2.up * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * 10 * Time.deltaTime);
        }
        
        if(transform.position.y >= playerOffset)
        {
            transform.position = new Vector2(transform.position.x, playerOffset);
        }

        if (transform.position.y <= -playerOffset)
        {
            transform.position = new Vector2(transform.position.x, -playerOffset);
        }
    }
}
