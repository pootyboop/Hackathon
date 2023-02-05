using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempTeleportTest : MonoBehaviour
{
    public static TempTeleportTest instance;
    public Transform camera;
    public Transform cameraOffset;

    public Transform[] teleportSpots;

    int currentTeleport = 0;



    private void Start()
    {
        instance = this;
    }



    public void IncerementTeleport()
    {
        currentTeleport++;
        if (currentTeleport > teleportSpots.Length - 1)
        {
            currentTeleport = 0;
        }

        Teleport(currentTeleport);
    }



    public void Teleport(int index)
    {
        Vector3 temp = teleportSpots[index].position - camera.localPosition;
        transform.position = (new Vector3(temp.x, 0.0f, temp.z));
    }
}
