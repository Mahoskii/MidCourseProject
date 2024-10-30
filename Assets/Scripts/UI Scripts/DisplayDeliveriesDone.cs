using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDeliveriesDone : UpdatePlayerScore
{
    public TextMeshProUGUI deliveriesDoneText;
    public OneScriptToRuleThemAll gameData;

    [Header("Events")]
    public GameEvent onGameWon;

    private void Awake()
    {
        PlayerScoreUpdate(deliveriesDoneText, gameData.currentRoundNumber, "Deliveries Done: ");
    }

    private void Update()
    {
        GoalReached();
    }

    public void UpdateDeliveriesDone()
    {
        if(gameData.currentRoundNumber < 5)
        {
            gameData.currentRoundNumber++;
        }
        PlayerScoreUpdate(deliveriesDoneText, gameData.currentRoundNumber, "Deliveries Done: ");
    }

    public void GoalReached()
    {
        if (gameData.currentRoundNumber == 5)
        {
            onGameWon.Raise();
        }
    }

   
}
