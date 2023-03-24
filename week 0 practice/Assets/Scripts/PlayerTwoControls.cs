using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoControls : MonoBehaviour
{
    public float playerOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * 10 * Time.deltaTime);
        }

        if (transform.position.y >= playerOffset)
        {
            transform.position = new Vector2(transform.position.x, playerOffset);
        }

        if (transform.position.y <= -playerOffset)
        {
            transform.position = new Vector2(transform.position.x, -playerOffset);
        }
    }
}
