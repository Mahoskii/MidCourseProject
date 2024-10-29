using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChangeInstructionsImage : MonoBehaviour, ICounterUpdate
{
    public int roundNumber = 0;
    public Image instructions;
    public GameObject confirmButton;
    public GameObject instructionsImage;
    public List<Sprite> InstructionsList = new List<Sprite>();

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void DisplayInstructions()
    {
        instructionsImage.SetActive(true);
        confirmButton.SetActive(true);
        instructions.sprite = InstructionsList[roundNumber];
        audioManager.PlaySFX(audioManager.startRound);
    }

    public void UpdateCounter()
    {
        if(roundNumber < 5)
        {
            roundNumber++;
        }
        else
        {
            roundNumber = 4;
        }
    }

}
