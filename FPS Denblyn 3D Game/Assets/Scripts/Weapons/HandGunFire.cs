using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public AudioSource EmptyAmmoSound;
    public bool isFiring = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.handgunAmmo < 1)
            {
                EmptyAmmoSound.Play();
            }
            else if (isFiring == false)
            {
                StartCoroutine(FiringHandGun());
            }
        }
    }

    IEnumerator FiringHandGun()
    {
        isFiring = true;
        GlobalAmmo.handgunAmmo -= 1;
        theGun.GetComponent<Animator>().Play("HandGunFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);

        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
