using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollision : MonoBehaviour
{
    Vector3 position, lastPosition;
    public Transform room, head;
    public Transform backupRespawn;

    Vector3[] positions = new Vector3[10];
    int index = 0;

    void FixedUpdate()
    {
        //lastPosition = position;
        //position = player.position;

        positions[index] = new Vector3(head.position.x , 0.0f, head.position.z);
        index++;
        if (index > positions.Length - 1)
        {
            index = 0;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Foot") && !collision.gameObject.CompareTag("Ground"))
        {
            print("head collision: " + collision.gameObject);
            // player.position = new Vector3(0,0,0);
            //Vector3 newOffset = LastPosition() - room.position;
            //room.position += newOffset;
            room.position = backupRespawn.position;
        }
    }



    Vector3 LastPosition()
    {

        int returnIndex;

        if (index == positions.Length - 1)
        {
            returnIndex = 0;
        }

        else
        {
            returnIndex = index + 1;
        }



        for (int i = 0; i < positions.Length; i++)
        {
            if (positions[returnIndex] == null)
            {
                returnIndex++;
            }

            else
            {
                return positions[returnIndex];
            }
        }

        return backupRespawn.position;
    }
}
