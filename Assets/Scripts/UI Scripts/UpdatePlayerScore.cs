using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdatePlayerScore : MonoBehaviour
{
    public TextMeshProUGUI deliveriesDoneText;
    public TextMeshProUGUI attemptsLeftText;
    public GameObject ChildTimer;
    private int currentDeliveryScore = 0;
    private int currentAttemptsScore = 3;

    [Header("Events")]
    public GameEvent GameWon;
    public GameEvent GameLost;

    private void Start()
    {
        PlayerDeliveryScoreUpdate();
        PlayerAttemptsScoreUpdate();
    }

    public void PlayerDeliveryScoreUpdate()
    {
        PlayerScoreUpdate(deliveriesDoneText, "Deliveries Done: ", currentDeliveryScore);
    }

    public void PlayerAttemptsScoreUpdate()
    {
        PlayerScoreUpdate(attemptsLeftText, "Attempts Left: ", currentAttemptsScore);
    }

    private void PlayerScoreUpdate(TextMeshProUGUI textToChange, string message, int currentScore)
    {
        textToChange.text = $"{message}{currentScore}";
    }

    public void UpdateCurrentDeliveryScore()
    {
        if(currentDeliveryScore <= 5)
        {
            currentDeliveryScore++;
        }
        else
        {
            currentDeliveryScore = 5;
        }
    }

    public void UpdateCurrentAttemptsScore()
    {
        if(currentAttemptsScore > 0)
        {
            currentAttemptsScore--;
        }
        else
        {
            currentAttemptsScore = 0;
        }
    }

    public void GameWinning()
    {
        if (currentDeliveryScore >= 5)
        {
            GameWon.Raise();
        }
    }

    public void GameLosing()
    {
        if (currentAttemptsScore <= 0)
        {
            GameLost.Raise();
            Debug.Log("entered");
        }
    }

    public void ActivateTimer()
    {
        ChildTimer.SetActive(true);
    }





}
