using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameRoundManager : MonoBehaviour, ICounterUpdate
{
    public StringVariables popUpTitle;
    public StringVariables popUpContent;
    public StringVariables gameOutcome;
    //public BoolVariable IsPaused;

    private int currentRound = 1;

    AudioManager audioManager;

    [Header("Events")]
    public GameEvent onPopUPCall;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Start()
    {
        OnGameStart();
    }

    public void OnGameStart()
    {
        CallPopUp("Your night shift is about to begin!", "can you make it through to the end?", "roundStart");
    }

    public void OnRoundStart()
    {
        CallPopUp($"Delivery Numer: {currentRound}", "Ready? Start!", "onGoing");
    }

    public void RoundPass()
    {
        CallPopUp("Delivery Complete!", "You have completed your delivery successfully!", "roundStart");
    }

    public void RoundFail()
    {
        CallPopUp("Delivery Failed!", "You have failed to complete this delivery", "roundStart");
    }

    public void OnGameWin()
    {
        CallPopUp("You win!", "Wow, you managed to keep your entry level job another day... Well done?", "gameEnd");
        audioManager.PlaySFX(audioManager.gameCompleteFast);
    }

    public void OnGameLose()
    {
        CallPopUp("Oh no! :(", "You have been fired", "gameEnd");
    }

    private void CallPopUp(string titleMessage, string contentMessage, string gameoutCome)
    {
        popUpTitle.value = titleMessage;
        popUpContent.value = contentMessage;
        gameOutcome.value = gameoutCome;
        //IsPaused.value = true;
        onPopUPCall.Raise();
    }

    public void UpdateCounter()
    {
        if(currentRound <= 5)
        {
            currentRound++;
        }
        else
        {
            currentRound = 5;
        }
        
    }
}
