using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doormat : MonoBehaviour
{
    public static Doormat instance;

    public bool steppedIn = false;


    private void Start()
    {
        instance = this;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Foot"))
        {
            steppedIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Foot"))
        {
            steppedIn = false;
        }
    }
}
