using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sliders : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider,_masterSlider;

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
    public void MasterVolume()
    {
        AudioManager.Instance.MasterVolume(_masterSlider.value);
    }
}
