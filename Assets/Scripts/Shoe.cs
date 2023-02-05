using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoe : MonoBehaviour
{
    public Footsteps footL, footR;
    public bool isRight = false;



    private void OnTriggerEnter(Collider other)
    {
        //print(gameObject + " overlapped " + other.gameObject);
        if (/*other.gameObject.GetInstanceID() == footL.GetInstanceID() && !isRight && */!footL.hasShoe)
        {
            //print("left success");
            footL.WearShoe();
            Destroy(gameObject);
        }

        else if (/*GameObject.ReferenceEquals(other.gameObject, footR) && isRight && */!footR.hasShoe)
        {
            //print("right success");
            footR.WearShoe();
            Destroy(gameObject);
        }
    }
}