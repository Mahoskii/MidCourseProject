using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDeliveriesDone : UpdatePlayerScore
{
    public TextMeshProUGUI deliveriesDoneText;
    public IntVariable deliveriesDone;
    private int currentScore;

    private void Awake()
    {
        PlayerScoreUpdate(deliveriesDoneText, deliveriesDone, "Deliveries Done: ", currentScore);
    }
    private void Update()
    {
        if(currentScore != deliveriesDone.value)
        {
            PlayerScoreUpdate(deliveriesDoneText, deliveriesDone, "Deliveries Done: ", currentScore);
        }
    }
   
}
