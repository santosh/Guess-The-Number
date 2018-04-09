using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    public int maxGuessesAllowed = 10;

    public Text text;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    void StartGame() {
        max = 1000;
        min = 1;
        NextGuess();
    }

    void NextGuess() {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 1) {
            SceneManager.LoadScene("Win");
        }
    }
}
