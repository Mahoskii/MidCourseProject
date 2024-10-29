using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public StringVariables outcome;
    public GameObject popUPWindow;
    //public BoolVariable IsPaused;
    [Header("Events")]
    public GameEvent RaiseInstructions;
    public GameEvent RoundStartPopUp;

    public void RoundOutcome()
    {
        switch (outcome.value)
        {
            case "onGoing":
                popUPWindow.SetActive(false);
                //Time.timeScale = 1f;
                //IsPaused.value = false;
                RaiseInstructions.Raise();
                break;

            case "roundStart":
                popUPWindow.SetActive(false);
                //IsPaused.value = false;
                RoundStartPopUp.Raise();

                break;

            case "gameEnd":
                popUPWindow.SetActive(false);
                //IsPaused.value = false;
                SceneManager.LoadSceneAsync("MainMenu");
                break;

        }
    }
}
