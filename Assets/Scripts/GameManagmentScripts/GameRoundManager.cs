using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameRoundManager : MonoBehaviour
{
    public Floatvariable remainingTime;
    public IntVariable deliveriesDone;
    public IntVariable attemptsLeft;
    public VectorVariable deliveryPointLocation;
    public StringVariables popUpTitle;
    public StringVariables popUpContent;
    public StringVariables gameOutcome;

    private List<float> RoundTimesList = new List<float> { 31, 31, 31, 41, 91, 91};
    private List<Vector2> DeliveryPointsLocationList = new List<Vector2> { new Vector2(4394, -116), new Vector2(4394,-116), new Vector2(914, 1816), new Vector2(4738, 1135), new Vector2(-798, 4078), new Vector2(7288, 4025)};

    [Header("Events")]
    public GameEvent onPopUPCall;
    public GameEvent onRoundStart;

    private void Start()
    {
        OnGameStart();
    }

    public void OnGameStart()
    {
        Time.timeScale = 0f;
        attemptsLeft.value = 3;
        deliveriesDone.value = 0;
        deliveryPointLocation.value = DeliveryPointsLocationList[deliveriesDone.value + 1];
        remainingTime.value = RoundTimesList[deliveriesDone.value + 1];
        CallPopUp("Your night shift is about to begin!", "can you make it through to the end?", "roundStart");
        
    }

    public void OnRoundStart()
    {
        //onRoundStart.Raise();
        CallPopUp($"Delivery Numer: {deliveriesDone.value + 1}", "Ready? Start!", "onGoing");
    }
    public void RoundFail()
    {
        Time.timeScale = 0f;
        //if the player fails the round, then reduce one attempt.
        attemptsLeft.value -= 1;
        //reset the timer to the correct time for this round.
        remainingTime.value = RoundTimesList[deliveriesDone.value + 1];
        
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
        remainingTime.value = RoundTimesList[deliveriesDone.value + 1];
        //change the location of the spawn point to the next location.
        deliveryPointLocation.value = DeliveryPointsLocationList[deliveriesDone.value + 1];

        CallPopUp("Delivery Complete!", "You have completed your delivery successfully!", "roundStart");
        //if the player managed to do all 5 deliveries, run the game win function that will rest the scene and show the game won message.
        if (deliveriesDone.value == 5 && attemptsLeft.value > 0)
        {
            CallPopUp("Congratulations!", "You completed all your deliveries and got a promotion!","gameEnd");
        }
    }

    public void CallPopUp(string titleMessage, string contentMessage, string gameoutCome)
    {
        popUpTitle.value = titleMessage;
        popUpContent.value = contentMessage;
        gameOutcome.value = gameoutCome;
        onPopUPCall.Raise();
    }

}
