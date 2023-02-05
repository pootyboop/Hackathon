using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightMaker : MonoBehaviour
{
    public static SpotlightMaker instance;

    public Spotlight spotlightPrefab;



    void Start()
    {
        instance = this;
    }

    

    public void MakeSpotlight(float x, float z)
    {
        Instantiate(spotlightPrefab, new Vector3(x, 0.0f, z), Quaternion.Euler(0, 0, 0));
    }
}
