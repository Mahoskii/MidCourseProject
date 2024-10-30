using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public OneScriptToRuleThemAll gameData;
    //public float remainingTime = 0;
    private bool isThereTime = true;
    [Header("Events")]
    public GameEvent onTimeOver;
    

    private void Start()
    {
        UpdateTimer();
    }

    void Update()
    {
        if (gameData.timeForThisRound > 0)
        {
            gameData.timeForThisRound -= Time.deltaTime;
            TimeDisplay(gameData.timeForThisRound);
            if (gameData.timeForThisRound <= 0.01)
            {
                onTimeOver.Raise();
            }

        }
        else if (gameData.timeForThisRound <= 0)
        {
            gameData.timeForThisRound = 0;
            TimeDisplay(gameData.timeForThisRound);
            if (gameData.timeForThisRound <= 0 && isThereTime)
            {
                gameData.timeForThisRound += 0.2f;
            }
        }
    }

    void TimeDisplay(float remainingTime)
    {
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void UpdateTimer()
    {
        gameData.timeForThisRound = gameData.RoundTimes[gameData.mainIndex];
        //remainingTime = gameData.timeForThisRound;
    }

    public void TurnSelfOff()
    {
        gameObject.SetActive(false);
    }
}
