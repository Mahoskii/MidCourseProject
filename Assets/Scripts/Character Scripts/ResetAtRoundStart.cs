using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAtRoundStart : MonoBehaviour
{
    public GameObject car, bike, pedestrian;

    public void ResetSelf()
    {
        car.transform.position = transform.position;
        bike.transform.position = transform.position;
        pedestrian.transform.position = transform.position;

        if (car.activeSelf)
        {
            car.SetActive(false);
        }
        else if (bike.activeSelf)
        {
            bike.SetActive(false);
        }
        else if (pedestrian.activeSelf)
        {
            pedestrian.SetActive(false);
        }
    }

    public void SetSelfActive()
    {
        car.SetActive(true);
    }
}
