using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    GameObject target;
    public GameObject[] characterArray;

    // Update is called once per frame
    void Update()
    {
        FindActivePlayer();
        Vector3 newPos = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
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
