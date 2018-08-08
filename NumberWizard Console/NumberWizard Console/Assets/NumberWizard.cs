using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }
	
    void StartGame(){
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number from " + min + " to " + max);
        Debug.Log("Tell me if your number is lower or higher than " + guess);
        Debug.Log("-Push Up = higher, Push Down = lower, Push Enter = Correct!-");
        max++;
    }

	// Update is called once per frame
	void Update () {        
        if (Input.GetKeyDown(KeyCode.UpArrow)){            
            min = guess;
            NextGuess();
        }else if (Input.GetKeyDown(KeyCode.DownArrow)){            
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("I knew I would get it eventually ;)");
            StartGame();
            NextGuess();
        }
    }

    void NextGuess(){        
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower then " + guess);
    }
}
