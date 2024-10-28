using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    AudioManager audioManager;
    public GameObject deliveryPoint;
    public Floatvariable remainingTime;
    public VectorVariable deliveryPointLocation;
    [Header("Events")]
    public GameEvent onDeliveryPointReached;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(remainingTime.value > 0)
        {
            collision.gameObject.transform.localScale = new Vector3(-250, 250, 250);
            Time.timeScale = 0f;
            //collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            deliveryPoint.transform.position = deliveryPointLocation.value;
            audioManager.PlaySFX(audioManager.levelComplete);
            onDeliveryPointReached.Raise();
        }
    }
}
