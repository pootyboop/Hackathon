using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator : MonoBehaviour
{
    public static Narrator instance;
    public AudioClip[] clips;

    private AudioSource audioSource;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }



    public void PlaySound(int index)
    {
        audioSource.clip = clips[index];
        audioSource.Play();
    }
}
