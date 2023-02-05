using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLights : MonoBehaviour
{
    public static StageLights instance;

    public GameObject stageLights;
    private AudioSource audioSource;



    void Start()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }



    public void ToggleLights(bool turnOn)
    {
        if (turnOn != stageLights.activeSelf)
        {
            stageLights.SetActive(turnOn);
            audioSource.Play();

            BlackScreen.instance.gameObject.SetActive(!turnOn);
        }

    }
}
