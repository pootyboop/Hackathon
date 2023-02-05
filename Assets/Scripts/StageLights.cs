using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLights : MonoBehaviour
{
    public static StageLights instance;

    public GameObject stageLights;



    void Start()
    {
        instance = this;
    }



    public void ToggleLights(bool turnOn)
    {
        if (turnOn != stageLights.activeSelf)
        {
            stageLights.SetActive(turnOn);

            BlackScreen.instance.gameObject.SetActive(!turnOn);
        }

    }
}
