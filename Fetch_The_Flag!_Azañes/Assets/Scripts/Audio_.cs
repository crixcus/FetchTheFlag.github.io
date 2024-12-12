using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_ : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip bgm;
    public AudioClip flag;
    public AudioClip openBgm;
    public AudioClip closeBgm;
    public AudioClip end;
    public AudioClip jump;
    public AudioClip win;

    MainMenu mm;
    GameOverScreen game;
    ballScript player;

    private void Start()
    {
        musicSource.clip = bgm;
        musicSource.loop = true;
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

    public void playSFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void playScreenBgm(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}
