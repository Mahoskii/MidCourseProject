using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    public TextMeshProUGUI popUpTitle;
    public TextMeshProUGUI popUpContent;
    public OneScriptToRuleThemAll gameData;
    public GameObject popUpParent;
  public void InitializePopUp()
    {
        popUpParent.SetActive(true);
        popUpTitle.text = gameData.popUpTitleForThisCase;
        popUpContent.text = gameData.popUpContentForThisCase;
    }
}
