using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour
{
    public static BlackScreen instance;



    void Start()
    {
        instance = this;
    }
}
