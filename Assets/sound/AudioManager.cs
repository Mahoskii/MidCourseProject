using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("-------- Audio Sourse------")]
    [SerializeField] AudioSource musicSourse;
    [SerializeField] AudioSource SfxSourse;

    [Header("-------- Audio Clip------")]
    public AudioClip backround;
    public AudioClip car;
    public AudioClip pageFlip;
    public AudioClip trapHit;
    public AudioClip gameComplete;
    public AudioClip gameCompleteFast;
    public AudioClip levelComplete;
    public AudioClip menuSelect;
    public AudioClip menuExit;
    public AudioClip menuStart;
    public AudioClip pickUp;
    public AudioClip characterSwap;
    public AudioClip typing;
    public AudioClip startRound;

    private AudioClip currentSfxClip;
    private void Start()
    {
        musicSourse.clip = backround;
        musicSourse.Play();
    }

    public void PlaySFX (AudioClip clip)
    {
        if (clip != null)
        {
            SfxSourse.PlayOneShot(clip);
            currentSfxClip = clip; 
        }
    }

    public void StopSFX(AudioClip clip)
    {
        if (currentSfxClip == clip) 
        {
            SfxSourse.Stop();
            currentSfxClip = null;
        }
    }

    public void StopAllSFX()
    {
        SfxSourse.Stop();
        currentSfxClip = null; 
    }
}
