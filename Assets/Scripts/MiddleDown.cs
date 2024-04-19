using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleDown : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    public AudioClip doorOpen;
    public ParticleSystem smoke;
    public GameObject ui;
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            showUI();
            
        }

    }

    public void DoorOpen()
    {
        animator.SetTrigger("Down");
        gameObject.GetComponent<AudioSource>().PlayOneShot(doorOpen);
        smoke.Play();

    }



    public void HideUI()
    { 
      ui.SetActive(false);
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;   
    }

    public void showUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;  
    }

    public void PressRight()
    {
        HideUI();
        DoorOpen();
    }

    public void PressWrong()
    {
        HideUI();
    }
}


