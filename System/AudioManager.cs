using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Souce")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip background;
    public AudioClip buttonPressed;
    public AudioClip points;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void sfxPlayer(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
