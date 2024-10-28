using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Windows;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public string[] characterNames;
    public float textSpeed;

    private int index;

    public GameObject playerAvatar;
    public GameObject bossAvatar;

    AudioManager audioManager;


    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if ((UnityEngine.Input.GetMouseButtonDown(0))||(UnityEngine.Input.GetKey("space")))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                audioManager.StopSFX(audioManager.typing);
            }
        }
    }
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void StartDialogue()
    {
        index = 0;
        ShowAvatar();
        audioManager.PlaySFX(audioManager.typing);
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            ShowAvatar();
            audioManager.PlaySFX(audioManager.typing);
            StartCoroutine(TypeLine());
        }
        else
        {
            SceneManager.LoadScene("01102024");
        }
    }
    void ShowAvatar()
    {
       
        playerAvatar.SetActive(false);
        bossAvatar.SetActive(false);

        
        if (characterNames[index] == "Player")
        {
            playerAvatar.SetActive(true);
        }
        else if (characterNames[index] == "Boss")
        {
            bossAvatar.SetActive(true);
        }
    }
}
