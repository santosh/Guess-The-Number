using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;

    // Use this for initialization
    void Start () {
        print("Welcome to the Number Wizard!");
        print("Pick a number in your head, but don't tell.");

        print("The hightest number you can pick is " + max + " and the lowest is " + min + ".");

        print("Is the number higher or lower than 500?");
        print("Up = higher, down = lower, return = equal");
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            print("Up arrow pressed");
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            print("Down arrow pressed");
         } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("Return pressed");
        }
    }
}
