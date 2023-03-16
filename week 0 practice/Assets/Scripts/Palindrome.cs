using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palindrome : MonoBehaviour
{
    int number = 234;
    
    void Start()
    {
        int reverse = 0;
        int reminder = 0;
        int tempNum = number;

        if (number != 0)
        {
            reminder = number % 10;
            reverse = reverse * 10 + reminder;
            number /=  10;

        }

        if(reverse == tempNum)
        {
            Debug.Log("Number is palindrome" + number);
        }
        else
        {
            Debug.Log("Number is not palindrome" + number);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
