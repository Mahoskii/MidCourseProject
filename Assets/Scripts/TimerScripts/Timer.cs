using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public static float remainingTime = 90;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            TimeDisplay(remainingTime);

        } else if(remainingTime <= 0)
        {
            remainingTime = 0;
            TimeDisplay(remainingTime);
        }
    }

    void TimeDisplay(float remainingTime)
    {
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
