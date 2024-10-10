using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeLaneTrap : MonoBehaviour, ITraps
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car") || collision.gameObject.CompareTag("Pedestrian"))
        {
            FailToPassTrap();
        }
    }

    public void FailToPassTrap()
    {
        Timer.remainingTime -= 5;
    }
}
