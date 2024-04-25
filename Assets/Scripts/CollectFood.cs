using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFood : MonoBehaviour
{

    public AudioClip foodClaim;
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

    public void GetEnergy()
    {

        gameObject.gameObject.GetComponent<AudioSource>().PlayOneShot(foodClaim);
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
        GetEnergy();
    }

    public void PressNo()
    {
        HideUI();
    }
    
   
}
