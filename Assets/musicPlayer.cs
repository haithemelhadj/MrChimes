using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlayer : MonoBehaviour
{
    public GameObject audioPlayer;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = audioPlayer.GetComponent<AudioSource>();
    }

    void PlaySoundEffect()
    {
        audioSource.Play();
    }
}
