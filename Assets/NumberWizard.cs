using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start() 
    {
        StartGame();

    }

    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Shalom, Welcome to number wizard Michaelo");
        Debug.Log("Pick a Number");
        Debug.Log("High number is: " + max);
        Debug.Log("Low number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = Lower, Push Enter = Correct");
        max++;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            Debug.Log(guess);
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            Debug.Log(max);
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))  {
            Debug.Log("I am a genius!!!");
            StartGame();
        }
    }

    void NextGuess() {
        guess = (min + max) / 2;
        Debug.Log("Is it Higher or lower than...." + guess);
    }
}
