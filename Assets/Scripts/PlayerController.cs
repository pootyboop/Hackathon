using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    enum stepStrength
    {
        WEAK, NORMAL, STRONG
    }

    public static PlayerController instance;

    //refs
    public Footsteps footL, footR;
    public GameObject XRRig;

    //standing
    public float standingHeight = 1.3f;
    public float crouchPercentage = 0.7f;

    //state
    float currentHeight;
    bool isCrouching = false;
    bool firstStep = false;

    //steps
    float weakStep = 0.3f;
    float normalStep = 0.6f;

    //misc refs
    public GameObject stageLights;

    //prefabs
    public ParticleSystem stepBurstWeak;
    public ParticleSystem stepBurstNormal;



    void Start()
    {
        instance = this;
    }



    void Update()
    {
        UpdateState();
    }



    void UpdateState()
    {
        currentHeight = transform.position.y;
        if (currentHeight / standingHeight <= crouchPercentage && !isCrouching)
        {
            isCrouching = true;
        }

        else if (currentHeight / standingHeight > crouchPercentage && isCrouching)
        {
            isCrouching = false;
        }
    }



    public void Step(float velocity, bool isRight, Collision collision)
    {
        stepStrength strength = GetStepStrength(velocity);

        print(strength.ToString());


        //first step
        if (!firstStep && strength == stepStrength.STRONG)
        {
            firstStep = true;
            UpdateStandingHeight();

            stageLights.SetActive(true);
        }


        if (collision.gameObject.CompareTag("Ground"))
        {
            StepParticles(strength, isRight);
        }
    }



    stepStrength GetStepStrength(float velocity)
    {
        if (velocity <= weakStep)
        {
            return stepStrength.WEAK;
        }

        else if (velocity <= normalStep)
        {
            return stepStrength.NORMAL;
        }

        else
        {
            return stepStrength.STRONG;
        }
    }
    


    void StepParticles(stepStrength strength, bool isRight)
    {
        ParticleSystem prefab;
        switch (strength)
        {
            case stepStrength.WEAK:
                prefab = stepBurstWeak;
                break;
            default:
                prefab = stepBurstNormal;
                break;
        }

        Vector3 position;

        if (isRight)
        {
            position = footR.transform.position;
        }

        else
        {
            position = footL.transform.position;
        }

        Instantiate(prefab, position, Quaternion.Euler(-90, 0, 0));
    }



    public void UpdateStandingHeight()
    {
        currentHeight = transform.position.y;
    }
}
