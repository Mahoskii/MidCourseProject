using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HighwayTrap : ITraps
{
    AudioManager audioManager;
    public OneScriptToRuleThemAll gameData;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FailToPassTrap(collision, audioManager, "Bike", "Pedestrian", gameData.timeForThisRound);
    }
}
