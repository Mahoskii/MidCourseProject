using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public abstract class ITraps : MonoBehaviour
{
    public void FailToPassTrap(Collision2D collision, AudioManager audioManager, string trapFail1, string trapFail2)
    {
        if (collision.gameObject.CompareTag(trapFail1) || collision.gameObject.CompareTag(trapFail2))
        {
            CountDown.remainingTime -= 5;
            audioManager.PlaySFX(audioManager.trapHit);
        }
    }


}
