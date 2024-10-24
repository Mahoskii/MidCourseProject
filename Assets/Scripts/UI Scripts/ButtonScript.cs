using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public StringVariables outcome;
    public GameObject popUPWindow;
    [Header("Events")]
    public GameEvent onGameStart;
    public void RoundOutcome()
    {
        switch (outcome.value)
        {
            case "onGoing":

                popUPWindow.SetActive(false);
                Time.timeScale = 1f;
                break;

            case "roundStart":
                popUPWindow.SetActive(false);
                onGameStart.Raise();
                break;

            case "gameEnd":
                popUPWindow.SetActive(false);
                //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                SceneManager.LoadSceneAsync("MainMenu");
                break;

        }
    }
}
