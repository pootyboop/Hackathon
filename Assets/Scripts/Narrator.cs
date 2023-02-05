using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrator : MonoBehaviour
{
    public static Narrator instance;
    public AudioClip[] clips;

    int clipIndex = -1;
    AudioSource audioSource;



    void Start()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }



    public void ProgressStory()
    {
        PlaySoundLinearIndex();
        SwitchOnClipIndex(clipIndex);
    }



    public void PlaySoundLinearIndex()
    {
        clipIndex++;
        PlaySound(clipIndex);
    }
        


    public void PlaySound(int index)
    {
        audioSource.clip = clips[index];
        audioSource.Play();
    }



    void SwitchOnClipIndex(int index)
    {
        switch (index)
        {
            //entered first spotlight
            case 1:
                SpotlightMaker.instance.MakeSpotlight(6.0f, 1.0f);
                break;
        }
    }
}
