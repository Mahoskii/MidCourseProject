using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameRoundManager : MonoBehaviour
{
    public Floatvariable remainingTime;
    public IntVariable deliveriesDone;
    public IntVariable attemptsLeft;
    //public VectorVariable deliveryPointLocation;
    public StringVariables popUpTitle;
    public StringVariables popUpContent;
    public StringVariables gameOutcome;
    public BoolVariable IsPaused;

    AudioManager audioManager;


    private List<float> RoundTimesList = new List<float> { 31, 31, 41, 91, 91, 0 };
    //private List<Vector2> DeliveryPointsLocationList = new List<Vector2> { new Vector2(4394, -116), new Vector2(914, 1816), new Vector2(4738, 1135), new Vector2(7288, 4025), new Vector2(-798, 4078), new Vector2(-798, 4078) };

    [Header("Events")]
    public GameEvent onPopUPCall;


    private void Awake()
    {
        Time.timeScale = 0f;
        attemptsLeft.value = 3;
        deliveriesDone.value = 0;
        //deliveryPointLocation.value = DeliveryPointsLocationList[deliveriesDone.value];
        remainingTime.value = RoundTimesList[deliveriesDone.value];

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
        CallPopUp($"Delivery Numer: {deliveriesDone.value + 1}", "Ready? Start!", "onGoing");
        Debug.Log(deliveriesDone.value);
    }
    public void RoundFail()
    {
        Time.timeScale = 0f;
        //if the player fails the round, then reduce one attempt.
        attemptsLeft.value -= 1;
        //reset the timer to the correct time for this round.
        remainingTime.value = RoundTimesList[deliveriesDone.value];
        CallPopUp("Delivery Failed!", "You have failed to complete this delivery", "roundStart");
        //if the player ran out of attempts, run the game over function that will reset the secne and show the lose message.
        if (attemptsLeft.value == 0 && deliveriesDone.value < 5)
        {
            CallPopUp("Oh no! :(", "You have been fired", "gameEnd");
        }
    }

    public void RoundPass()
    {
        //if the player passes the round, add one to deliveries done.
        deliveriesDone.value += 1;
        //change the timer to the new timer for the new round.
        remainingTime.value = RoundTimesList[deliveriesDone.value];

        CallPopUp("Delivery Complete!", "You have completed your delivery successfully!", "roundStart");
        //if the player managed to do all 5 deliveries, run the game win function that will rest the scene and show the game won message.
        if (deliveriesDone.value == 5 && attemptsLeft.value > 0)
        {
            CallPopUp("You win!", "Wow, you managed to keep your entry level job another day... Well done?", "Back to main menu");
            audioManager.PlaySFX(audioManager.gameCompleteFast);
        }
    }

    public void CallPopUp(string titleMessage, string contentMessage, string gameoutCome)
    {
        popUpTitle.value = titleMessage;
        popUpContent.value = contentMessage;
        gameOutcome.value = gameoutCome;
        IsPaused.value = true;
        onPopUPCall.Raise();
    }
}
