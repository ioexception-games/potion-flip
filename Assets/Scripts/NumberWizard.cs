using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NumberWizard : MonoBehaviour
{
    [SerializeField]
    int gameMax;

    [SerializeField]
    int gameMin;

    [SerializeField]
    TextMeshProUGUI guessText;

    int currentGuess;
    int max;
    int min;

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

    public void StartGame()
    {
        max = gameMax + 1;
        min = gameMin;

        NextGuess();
    }

    void NextGuess()
    {
        currentGuess =  (max + min) / 2;
        guessText.text = currentGuess.ToString();
    }

}
