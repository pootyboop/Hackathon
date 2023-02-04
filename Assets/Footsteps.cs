using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    void Start()
    {
        print("start");
    }



    private void OnCollisionEnter(Collision collision)
    {

        print("collision!");

        if (collision.gameObject.CompareTag("Ground"))
        {
            print("collision detect: " + collision.contacts[0]);
        }
    }
}
