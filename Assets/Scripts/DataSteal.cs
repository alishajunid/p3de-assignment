using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSteal : MonoBehaviour

{

    public AudioClip stealSound;

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

    public void GetData()
    {

        gameObject.gameObject.GetComponent<AudioSource>().PlayOneShot(stealSound);
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

    public void PressProceed()
    {
        HideUI();
        GetData();
    }

    public void PressCancel()
    {
        HideUI();
    }
}


