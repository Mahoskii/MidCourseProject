using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public StringVariables outcome;
    public GameObject popUPWindow;
    public void RoundOutcome()
    {
        switch (outcome.value)
        {
            case "onGoing":

                popUPWindow.SetActive(false);
                Time.timeScale = 1f;

                break;

            case "gameEnd":
                popUPWindow.SetActive(false);
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                SceneManager.LoadSceneAsync("MainMenu");
                break;

        }
    }
}
