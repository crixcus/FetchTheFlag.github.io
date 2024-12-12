using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Screen2 : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip openBgm;
    public AudioClip closeBgm;

    MainMenu mm;
    GameOverScreen game;

    private void Start()
    {
        musicSource.clip = closeBgm;
        musicSource.Play();
    }

    public void PlayBgm()
    {
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    public void StopBgm()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }
}
