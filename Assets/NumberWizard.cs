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


        Debug.Log("Welcom to number wizard Michaelo");
        Debug.Log("Pick a Number");
        Debug.Log("High number is: " + max);
        Debug.Log("Low number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higher, Push Down = Lower, Push Enter = Correct");


    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up Arrow key was pressed.");
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow key was pressed.");
        } else if (Input.GetKeyDown(KeyCode.Return))  {
            Debug.Log("Return key was pressed.");
        }

    }
}
