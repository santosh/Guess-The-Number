using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won!");
            StartGame();
        }
    }

    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        print("=============================");
        print("Welcome to the Number Wizard!");
        print("Pick a number in your head, but don't tell.");

        print("The hightest number you can pick is " + max + " and the lowest is " + min + ".");

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal");
        max = max + 1;
    }

    void NextGuess() {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal");
    }
}
