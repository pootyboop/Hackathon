using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempTeleportTest : MonoBehaviour
{

    public Transform camera;
    public Transform cameraOffset;

    public Transform[] teleportSpots;

    int currentTeleport = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            currentTeleport++;
            if (currentTeleport > teleportSpots.Length - 1) currentTeleport = 0 ;

            Vector3 temp = teleportSpots[currentTeleport].position - camera.localPosition;
            transform.position = (new Vector3(temp.x, 0.0f, temp.z));
        }
    }
}
