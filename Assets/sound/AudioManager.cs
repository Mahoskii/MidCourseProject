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
    public AudioClip menuSelect;


    private void Start()
    {
        musicSourse.clip = backround;
        musicSourse.Play();
    }

    public void PlaySFX (AudioClip clip)
    {
        SfxSourse.PlayOneShot (clip);
    }
}
