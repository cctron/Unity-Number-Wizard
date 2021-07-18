using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is ...");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key: KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed");
        }

        if (Input.GetKeyDown(key: KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed");
        }

        if (Input.GetKeyDown(key: KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
        }
    }
}
