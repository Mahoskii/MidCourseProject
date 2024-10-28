using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public Floatvariable remainingTime;
    [Header("Events")]
    public GameEvent onTimeOver;
    private bool isThereTime = true;

    void Update()
    {
        if (remainingTime.value > 0)
        {
            remainingTime.value -= Time.deltaTime;
            TimeDisplay(remainingTime.value);
            if (remainingTime.value <= 0.01)
            {
                onTimeOver.Raise();
            }

        }
        else if (remainingTime.value <= 0)
        {
            remainingTime.value = 0;
            TimeDisplay(remainingTime.value);
            if (remainingTime.value <= 0 && isThereTime)
            {
                remainingTime.value += 0.2f;
            }
        }
    }

    void TimeDisplay(float remainingTime)
    {
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
