using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnAndOff : MonoBehaviour
{
    public GameObject objectToTurn;

    public void TurnOff()
    {
        objectToTurn.SetActive(false);
    }

    public void TurnOn()
    {
        objectToTurn.SetActive(true);
    }
}
