using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeLaneTrap : ITraps
{
    AudioManager audioManager;
    public OneScriptToRuleThemAll gameData;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FailToPassTrap(collision, audioManager, "Car", "Pedestrian", gameData.timeForThisRound);
    }

}



