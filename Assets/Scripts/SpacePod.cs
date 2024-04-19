using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePod : MonoBehaviour
{

    public AudioClip dangerSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            gameObject.gameObject.GetComponent<AudioSource>().PlayOneShot(dangerSound);
        }
    }
}
