using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public bool isRight = false;
    Vector3 lastPosition, currentPosition;
    const float maxStrength = 6.0f;

    private void FixedUpdate()
    {
        lastPosition = currentPosition;
        currentPosition = transform.position;
    }



    private void OnCollisionEnter(Collision collision)
    {

        //print("collision!");

        if (collision.gameObject.CompareTag("Ground"))
        {
            print(StepStrength(lastPosition, currentPosition));
        }
    }



    float StepStrength(Vector3 pos1, Vector3 pos2)
    {
        float strength = Vector3.Distance(pos1, pos2) * 100.0f;
        
        return Mathf.Clamp(strength / maxStrength, 0.0f, 1.0f);
    }
}