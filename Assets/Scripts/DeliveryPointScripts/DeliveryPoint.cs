using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPoint : MonoBehaviour
{
    AudioManager audioManager;
    public GameObject deliveryPoint;
    public OneScriptToRuleThemAll gameData;
  
    

    [Header("Events")]
    public GameEvent onDeliveryPointReached;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameData.timeForThisRound > 0)
        {
            if(gameData.mainIndex < 4)
            {
                gameData.mainIndex++;
            } else if(gameData.mainIndex == 4)
            {
                gameData.mainIndex = 0;
            }
            deliveryPoint.transform.position = gameData.DeliveryHousePoints[gameData.mainIndex];
            audioManager.PlaySFX(audioManager.levelComplete);
            onDeliveryPointReached.Raise();
        }
    }

}

//AudioManager audioManager;
//public GameObject deliveryPoint;
//public Floatvariable remainingTime;
//public VectorVariable deliveryPointLocation;
//public DeliveryPointScriptable DeliveryPointLocations;
//public int deliveryIndex = 0;
//[Header("Events")]
//public GameEvent onDeliveryPointReached;

//private void Awake()
//{
//    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
//}

//void OnCollisionEnter2D(Collision2D collision)
//{
//    if (remainingTime.value > 0)
//    {
//        if (deliveryIndex < 5)
//        {
//            deliveryIndex++;
//        }
//        else if (deliveryIndex == 5)
//        {
//            deliveryIndex = 0;
//        }
//        //collision.gameObject.transform.localScale = new Vector3(-250, 250, 250);
//        //Time.timeScale = 0f;
//        //collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
//        deliveryPoint.transform.position = DeliveryPointLocations.DeliveryPointsLocationList[deliveryIndex];
//        audioManager.PlaySFX(audioManager.levelComplete);
//        onDeliveryPointReached.Raise();
//        Debug.Log(deliveryIndex);
//    }
//}
