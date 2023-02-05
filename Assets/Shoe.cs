using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoe : MonoBehaviour
{
    public Footsteps footL, footR;
    public bool isRight = false;



    private void OnTriggerEnter(Collider other)
    {
        print("overlapped " + other.gameObject);
        if (GameObject.ReferenceEquals(other.gameObject, footL) && !isRight && !footL.hasShoe)
        {
            print("left success");
            footL.WearShoe();
            Destroy(gameObject);
        }

        else if (GameObject.ReferenceEquals(other.gameObject, footR) && isRight && !footR.hasShoe)
        {
            print("right success");
            footR.WearShoe();
            Destroy(gameObject);
        }
    }
}
