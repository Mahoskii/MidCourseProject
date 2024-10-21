using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
 
    [SerializeField] Slider volumeSlider;


    public void ExitGame()
    {
        UnityEngine.Application.Quit();
        Debug.Log("Game Closed");
      

    }

    public void StartGame()
    {
        SceneManager.LoadScene("01102024");
       
    }

    private void Awake()
    {
       
        
        if (PlayerPrefs.HasKey("Volume"))
        {
            SetVolume(PlayerPrefs.GetFloat("Volume"));
            volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        }
        
    }

    public void SetVolume (float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume" , volume);
    }
}
