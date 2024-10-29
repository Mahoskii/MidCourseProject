using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour, ICounterUpdate
{
    public TextMeshProUGUI timerText;
    public RoundScriptableObject[] RoundTimesArray;
    public GameObject Timer;
    
    private float remainingTime;
    private bool isThereTime = true;
    private int RoundTimerIndex = 0;

    [Header("Events")]
    public GameEvent onTimeOver;

    private void Start()
    {
        SetRoundTime();
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            TimeDisplay(remainingTime);
            if (remainingTime <= 0.01)
            {
                onTimeOver.Raise();
            }

        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            TimeDisplay(remainingTime);
            if (remainingTime <= 0 && isThereTime)
            {
                remainingTime += 0.2f;
            }
        }
    }

    private void TimeDisplay(float remainingTime)
    {
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void HideTime()
    {
        Timer.SetActive(false);
    }

    public void SetRoundTime()
    {
        remainingTime = RoundTimesArray[RoundTimerIndex].RoundTime;
    }

    public void UpdateCounter()
    {
        if(RoundTimerIndex < RoundTimesArray.Length - 1)
        {
            RoundTimerIndex++;
        }
    }
}
