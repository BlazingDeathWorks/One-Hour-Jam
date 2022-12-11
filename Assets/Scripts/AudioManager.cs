using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sound;

    public void Sound()
    {
        audioSource.PlayOneShot(sound);
    }
}
