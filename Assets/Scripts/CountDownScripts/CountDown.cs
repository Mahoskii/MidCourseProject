using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public OneScriptToRuleThemAll roundTimeSupplier;
    public float remainingTime = 0;
    [Header("Events")]
    public GameEvent onTimeOver;
    private bool isThereTime = true;

    private void Start()
    {
        UpdateTimer();
        roundTimeSupplier.timeIndex++;
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

    void TimeDisplay(float remainingTime)
    {
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void UpdateTimer()
    {
        remainingTime = roundTimeSupplier.RoundTimes[roundTimeSupplier.timeIndex];
    }
    public void UpdateCounter()
    {
        if (roundTimeSupplier.timeIndex < 4)
        {
            roundTimeSupplier.timeIndex++;
        }
    }
    public void TurnSelfOff()
    {
        gameObject.SetActive(false);
    }
    public void ResetCounter()
    {
        roundTimeSupplier.timeIndex = 0;
    }
}
