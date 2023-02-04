using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;

    public GameObject[] scenes;
    int sceneIndex = 0;

    private void Start()
    {
        instance = this;

        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i].SetActive(false);
        }

        OpenScene(0);
    }

    public void OpenScene(int index)
    {
        scenes[sceneIndex].SetActive(false);
        sceneIndex = index;
        scenes[sceneIndex].SetActive(true);
    }
}
