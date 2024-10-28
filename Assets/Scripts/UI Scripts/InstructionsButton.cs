using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsButton : MonoBehaviour
{
    public GameObject ImageWindow;

    [Header("Events")]
    public GameEvent onRoundStart;

    public void OnClick()
    {
        ImageWindow.SetActive(false);
        gameObject.SetActive(false);
        onRoundStart.Raise();
    }
}
