using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAtRoundStart : MonoBehaviour
{
    public GameObject car, bike, pedestrian;
    public GameObject[] CharacterList = new GameObject[3];

    public void ResetSelf()
    {
        for(int i = 0; i < CharacterList.Length; i++)
        {
            Time.timeScale = 1f;
            CharacterList[i].transform.position = transform.position;
            CharacterList[i].transform.localScale = new Vector3(250, 250, 250);
            CharacterList[i].SetActive(false);
            Time.timeScale = 0f;
        }

    }

    public void SetSelfActive()
    {
        car.SetActive(true);
    }
}
