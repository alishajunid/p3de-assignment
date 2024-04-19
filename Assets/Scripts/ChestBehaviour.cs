using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehaviourScript : MonoBehaviour
{

    public Animator animator;
    public AudioClip chestSound;
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
            animator.SetTrigger("Open");
            gameObject.gameObject.GetComponent<AudioSource>().PlayOneShot(chestSound);
        }
    }
}
