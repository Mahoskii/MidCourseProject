using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdatePlayerScore : MonoBehaviour
{
    public void PlayerScoreUpdate(TextMeshProUGUI textToChange, IntVariable valueToChange, string message, int currentScore)
    {
        textToChange.text = $"{message}{valueToChange.value}";
        currentScore = valueToChange.value;
    }
}
