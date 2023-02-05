using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBall : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < 0.0f)
            Destroy(gameObject);
    }
}
