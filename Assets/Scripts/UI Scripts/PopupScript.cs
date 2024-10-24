using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    public TextMeshProUGUI popUpTitle;
    public TextMeshProUGUI popUpContent;
    public StringVariables popUpTitleValue;
    public StringVariables popUpContentValue;
    public GameObject popUpParent;
  public void InitializePopUp()
    {
        popUpParent.SetActive(true);
        popUpTitle.text = popUpTitleValue.value;
        popUpContent.text = popUpContentValue.value;
    }
}
