using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]
    int max;

    [SerializeField]
    int min;

    int currentGuess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        min = currentGuess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = currentGuess;
        NextGuess();
    }

    void StartGame()
    {
        max = max + 1;

        NextGuess();
    }

    void NextGuess()
    {
        currentGuess =  (max + min) / 2;
    }

}
