using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChangeInstructionsImage : MonoBehaviour
{
    public int roundNumber = 0;
    public Image instructions;
    public GameObject confirmButton;
    public GameObject instructionsImage;
    public List<Sprite> InstructionsList = new List<Sprite>();

    AudioManager audioManager;

    public void DisplayInstructions()
    {
        instructionsImage.SetActive(true);
        confirmButton.SetActive(true);
        instructions.sprite = InstructionsList[roundNumber];
        roundNumber++;
        audioManager.PlaySFX(audioManager.startRound);
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

}
