using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLightTrap : MonoBehaviour, ITraps
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car") || collision.gameObject.CompareTag("Bike"))
        {
            FailToPassTrap();
        }
    }

    public void FailToPassTrap()
    {
        CountDown.remainingTime -= 5;
    }
}
