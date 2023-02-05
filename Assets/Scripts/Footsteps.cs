using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public bool isRight = false;
    public bool hasShoe = false;
    public GameObject shoe;
    Vector3 lastPosition, currentPosition;
    const float maxStrength = 5.0f;

    bool justStepped = true;
    float footstepTimer = -1.0f;
    float timeBetweenFootsteps = 0.4f;



    private void Update()
    {
        UpdateStepTimer();
    }



    void UpdateStepTimer()
    {
        if (justStepped)
        {
            footstepTimer += Time.deltaTime;
            if (footstepTimer > timeBetweenFootsteps)
            {
                justStepped = false;
            }
        }
    }



    private void FixedUpdate()
    {
        lastPosition = currentPosition;
        currentPosition = transform.position;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (!justStepped)
        {
            PlayerController.instance.Step(StepStrength(lastPosition, currentPosition), isRight, collision);
            footstepTimer = 0.0f;
            justStepped = true;
        }

        //print("collision!");

        /*
        if (collision.gameObject.CompareTag("Ground"))
        {
            //print(StepStrength(lastPosition, currentPosition));
        }
        */
    }



    float StepStrength(Vector3 pos1, Vector3 pos2)
    {
        float strength = Vector3.Distance(pos1, pos2) * 100.0f;
        
        return Mathf.Clamp(strength / maxStrength, 0.0f, 1.0f);
    }



    public void WearShoe()
    {
        hasShoe = true;
        shoe.SetActive(true);
    }
}