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

    // Update is called once per frame
    void Update()
    {
        FindActivePlayer();
        Vector3 newPos = new Vector3(target.transform.position.x + xOffset, target.transform.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
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
