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
    public float targetDistance;
    public int damageAmount = 5;
    public int show=0;

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
        RaycastHit theShot;
        isFiring = true;
        GlobalAmmo.handgunAmmo -= 1;
        theGun.GetComponent<Animator>().Play("HandGunFire");
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);

        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);

        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
