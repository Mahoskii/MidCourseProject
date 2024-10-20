using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(CountDown.remainingTime > 0)
        {
            collision.gameObject.transform.position = new Vector2(0f, 0f);
            audioManager.PlaySFX(audioManager.levelComplete);
        }
    }
}
