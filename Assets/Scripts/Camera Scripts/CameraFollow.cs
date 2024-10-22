using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 250f;
    public float xOffset = 250f;
    GameObject target;
    public GameObject[] characterArray;
    public Vector3 minValue, maxValue;
    public Vector3 targetPosition;

    void Start()
    {
        
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minValue.x, maxValue.x),
            Mathf.Clamp(transform.position.y, minValue.y, maxValue.y),
            -10f);
    }
    void Update()
    {
        FindActivePlayer();
        if (target != null)
        {
           
            Vector3 targetPosition = new Vector3( 
                target.transform.position.x + xOffset,
                target.transform.position.y + yOffset,
                -10f);


            Vector3 clampedPosition = new Vector3(
               Mathf.Clamp(targetPosition.x, minValue.x, maxValue.x),
               Mathf.Clamp(targetPosition.y, minValue.y, maxValue.y),
               -10f);


            transform.position = Vector3.Slerp(transform.position, clampedPosition, FollowSpeed * Time.deltaTime);
        }
    }

    public void FindActivePlayer()
    {
        for(int i = 0; i < characterArray.Length; i++)
        {
            if (characterArray[i].activeSelf)
            {
                target = characterArray[i];
            }
        }
    }
}
