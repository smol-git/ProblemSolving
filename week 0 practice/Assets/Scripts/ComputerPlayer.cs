using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPlayer : MonoBehaviour
{
    
    public float offset;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {  
        transform.Translate(Vector2.up * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= offset)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
           
        }
        if(transform.position.y <= -offset)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            
        }
    }
}
