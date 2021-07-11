using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Hi, this is a Number Guessing Game. Don't tell the number to me. I'll guess your number correctly");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("If my guess was higher that your number, click up arrow.");
        Debug.Log("If my guess was lower that your number, click down arrow.");
        Debug.Log("Your number is greater or less than 500?");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Hooray! My guess was correct. Your number is " + guess + ". Right !?");
            StartGame();
        }

    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Your number is greater or less than " + guess + "?");
    }
}
