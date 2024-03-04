using UnityEngine;
using System;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource musicSource,sfxSource,masterSource;
    public Sound[] musicSounds,sfxSounds,masterSounds;
    [SerializeField] Slider volumeSlider;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayBottonSound()
    {
        PlaySFX("SFX");
    }

    private void Start()
    {
        PlayMusic("Backround");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not found");
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not found");
        }

        else
        {
            sfxSource.PlayOneShot(s.clip);
            
        }
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    public void MasterVolume(float volume)
    {
        masterSource.volume = volume;
        sfxSource.volume = volume;
        musicSource.volume = volume;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}