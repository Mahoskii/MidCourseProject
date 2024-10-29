using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class OneScriptToRuleThemAll : ScriptableObject
{
    public int mainIndex;
    
    //Time control variables
    public float timeForThisRound;
    public int timeIndex = 0;
    public List<float> RoundTimes = new List<float>()
    {
        31, 36, 41, 76, 91
    };

    //Delivery points location control variables
    public Vector2 deliveryPointForThisRound;
    public int deliveryPointIndex = 0;
    public List<Vector2> DeliveryHousePoints = new List<Vector2>()
    {
        new Vector2(4394, -116),
        new Vector2(914, 1816),
        new Vector2(4738, 1135),
        new Vector2(7288, 4025),
        new Vector2(-798, 4078)
    };

    //Traps spawn location control variables
    public Vector2 trapSpawnPointsForThisRound;
    public int trapPointsIndex = 0;
    public List<Vector2> TrapSpawnPoints = new List<Vector2>();

    //Deliveries done controls
    public int currentRoundNumber;
    public int roundNumberIndex = 0;
    public List<int> RoundNumber = new List<int>() { 1, 2, 3, 4, 5 };

    //Attempts left controls
    public int attemptsCurrentlyLeft;
    public int attemptsLeftIndex = 0;
    public List<int> AttemptsNumber = new List<int>() { 3, 2, 1, 0 };


    //PopUp title control variables
    public string popUpTitleForThisCase;
    public int popUpTitleIndex = 0;
    public List<string> PopUpTitleList = new List<string>()
    {
        //           game start,                  round start,       round failed,     game lost,       round won,        game won
        "Your night shift is about to begin!", "Delivery Numer: ", "Delivery Failed!", "Oh no! :(", "Delivery Complete!", "You win!"
    };

    //PopUp content control variables
    public string popUpContentForThisCase;
    public int popUpContentIndex = 0;
    public List<string> PopUpContentList = new List<string>()
    {
        //           game start,                round start,                   round failed,                        game lost,                         round won,                                                   game won
        "can you make it through to the end?", "Ready? Start!", "You have failed to complete this delivery", "You have been fired", "You have completed your delivery successfully!", "Wow, you managed to keep your entry level job another day... Well done?"
    };

    //PopUp state/condition control variables
    public string popUpConditionForThisCase;
    public int popUpConditionIndex = 0;
    public List<string> PopUpCondition = new List<string>()
    {
        "roundStart", "onGoing", "gameEnd"
    };

    //Using Override to Update Shared Variables

    //For Time
    public void UpdateVariable(int index, List<float> list, float variable)
    {
        if(index < list.Count)
        {
            variable = list[index];
        }
    }
    //For Delivery Points Locations and Traps Spawn Points Locations
    public void UpdateVariable(int index, List<Vector2> list, Vector2 variable)
    {
        if (index < list.Count)
        {
            variable = list[index];
        }
    }
    //For Deliveries Done and Attempts Left
    public void UpdateVariable(int index, List<int> list, int variable)
    {
        if (index < list.Count)
        {
            variable = list[index];
        }
    }
    //For The PopUp Messages and Conditions
    public void UpdateVariable(int index, List<string> list, string variable)
    {
        if (index < list.Count)
        {
            variable = list[index];
        }
    }

    //Increment and Decrement the Counters
    public void IncrementCounters(int index, List<float> list)
    {
        if(index < list.Count - 1)
        {
            index++;
        }
    }

    public void IncrementCounters(int index, List<Vector2> list)
    {
        if (index < list.Count - 1)
        {
            index++;
        }
    }

    public void IncrementCounters(int index, List<int> list)
    {
        if (index < list.Count - 1)
        {
            index++;
        }
    }

    public void IncrementCounters(int index, List<string> list)
    {
        if (index < list.Count - 1)
        {
            index++;
        }
    }

    public void DecrementCounters(int index)
    {
        if (index > 0)
        {
            index--;
        }
    }
}
