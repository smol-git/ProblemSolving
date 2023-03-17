using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palindrome : MonoBehaviour
{
    int number = 232;
    
    void Start()
    {
        CheckPalindrome();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void CheckPalindrome()
    {
        int reverse = 0;
        int reminder = 0;
        int tempNum = number;

        while(number != 0)
        {
            reminder = number % 10;
            reverse = reverse * 10 + reminder;
            number /= 10;

        }
        Debug.Log(number);

        if (reverse == tempNum)
        {
            Debug.Log("Number is palindrome" + reverse);
        }
        else
        {
            Debug.Log("Number is not palindrome" + reverse);
        }
    }
}
