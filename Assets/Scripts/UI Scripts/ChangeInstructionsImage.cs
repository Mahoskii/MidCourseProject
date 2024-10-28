using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeInstructionsImage : MonoBehaviour
{
    public IntVariable deliveriesDone;
    public Image instructions;
    public List<Image> InstructionsList = new List<Image>();

    public void DisplayInstructions()
    {
        instructions = InstructionsList[deliveriesDone.value];
    }
}
