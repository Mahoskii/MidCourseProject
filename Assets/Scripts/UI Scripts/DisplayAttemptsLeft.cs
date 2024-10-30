using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayAttemptsLeft : UpdatePlayerScore
{
    public TextMeshProUGUI attemptsLeftText;
    public OneScriptToRuleThemAll gameData;

    [Header("Events")]
    public GameEvent onGameLost;

    private void Awake()
    {
        PlayerScoreUpdate(attemptsLeftText, gameData.attemptsCurrentlyLeft, "Attempts Left: ");
    }
    private void Update()
    {
        Failed();
    }
    public void UpdateAttempts()
    {
        if(gameData.attemptsCurrentlyLeft > 0)
        {
            gameData.attemptsCurrentlyLeft--;
        }

        PlayerScoreUpdate(attemptsLeftText, gameData.attemptsCurrentlyLeft, "Attempts Left: ");
    }

    public void Failed()
    {
        if (gameData.attemptsCurrentlyLeft == 0)
        {
            onGameLost.Raise();
        }
    }

}
