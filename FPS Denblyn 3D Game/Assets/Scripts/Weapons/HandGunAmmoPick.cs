using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public GameObject Message;
    public AudioSource ammoPickUpSound;
    public bool IsPickUp = false;

    void Update()
    {
        if (IsPickUp == true && Input.GetKeyDown(KeyCode.F))
        {
            fakeAmmoClip.SetActive(false);
            ammoPickUpSound.Play();
            GetComponent<BoxCollider>().enabled = false;
            GlobalAmmo.handgunAmmo += 7;
            Message.SetActive(false);
            IsPickUp = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IsPickUp = true;
        Message.SetActive(true);
        Message.GetComponent<Text>().text = "Press 'F' to pick up";
    }
    private void OnTriggerExit(Collider other)
    {
        IsPickUp = false;
        Message.SetActive(false);
    }
}
