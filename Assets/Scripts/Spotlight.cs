using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight : MonoBehaviour
{
    public float lifetime = 6.0f;
    public bool autoDestroy = true;


    void Start()
    {
        transform.position = new Vector3(transform.position.x, 6.0f, transform.position.z);
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Foot"))
        {
            Narrator.instance.ProgressStory();

            //disable collision and cleanup
            Destroy(GetComponent<Collider>());
            StartCoroutine(SpotlightAutoDestroy(lifetime));
        }
    }



    IEnumerator SpotlightAutoDestroy(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
