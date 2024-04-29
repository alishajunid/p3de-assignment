using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorData : MonoBehaviour

{ 
    public AudioClip projectorClaim;
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

public void GetProjector()
{

    gameObject.gameObject.GetComponent<AudioSource>().PlayOneShot(projectorClaim);
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

public void PressYes()
{
    HideUI();
    GetProjector();
}

public void PressNo()
{
    HideUI();
}

}

