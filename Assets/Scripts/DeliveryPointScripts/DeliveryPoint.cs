using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(CountDown.remainingTime > 0)
        {
            collision.gameObject.transform.position = new Vector2(0f, 0f);
        }
    }
}
