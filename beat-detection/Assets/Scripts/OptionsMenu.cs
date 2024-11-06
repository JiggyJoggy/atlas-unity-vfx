using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MainMenu
{
    public Canvas OptionsCanvas;
    public Canvas GameCanvas;

    public AudioSource AudioSource;
    public AudioClip EasyClip;
    public AudioClip MediumClip;
    public AudioClip HardClip;

    public void EasySong()
    {
        AudioSource.clip = EasyClip;
        AudioSource.Play();
        SwitchCanvas();
    }

    public void MediumSong()
    {
        AudioSource.clip = MediumClip;
        AudioSource.Play();
        SwitchCanvas();
    }
    public void HardSong()
    {
        AudioSource.clip = HardClip;
        AudioSource.Play();
        SwitchCanvas();
    }

    public void SwitchCanvas()
    {
        OptionsCanvas.enabled = false;
        GameCanvas.enabled = true;
    }
}
