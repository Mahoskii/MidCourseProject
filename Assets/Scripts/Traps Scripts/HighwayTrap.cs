using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HighwayTrap : MonoBehaviour, ITraps
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bike") || collision.gameObject.CompareTag("Pedestrian"))
        {
            FailToPassTrap();
        }
    }

    public void FailToPassTrap()
    {
        CountDown.remainingTime -= 5;
    }
}
