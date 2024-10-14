using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BikeLaneTrap : MonoBehaviour, ITraps
{
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car") || collision.gameObject.CompareTag("Pedestrian"))
        {
            FailToPassTrap();
            audioManager.PlaySFX(audioManager.trapHit);
        }
    }

    public void FailToPassTrap()
    {
        CountDown.remainingTime -= 5;
        
    }
}



