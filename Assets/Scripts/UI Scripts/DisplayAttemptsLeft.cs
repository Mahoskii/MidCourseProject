using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayAttemptsLeft : UpdatePlayerScore
{
    public TextMeshProUGUI attemptsLeftText;
    public IntVariable attemptsLeft;
    private int currentScore = 3;

    private void Awake()
    {
        PlayerScoreUpdate(attemptsLeftText, attemptsLeft, "Attempts Left: ", currentScore);
    }
    private void Update()
    {
        if (currentScore != attemptsLeft.value)
        {
            PlayerScoreUpdate(attemptsLeftText, attemptsLeft, "Attempts Left: ", currentScore);
        }
    }
}
