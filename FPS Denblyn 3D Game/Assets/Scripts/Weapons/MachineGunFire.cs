using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public AudioSource EmptyAmmoSound;
    public bool isFiring = false;
    public float targetDistance;
    public int damageAmount = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (GlobalAmmo.machinegunAmmo < 1)
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
        GlobalAmmo.machinegunAmmo -= 1;
        theGun.GetComponent<Animator>().Play("MachineGunFire");
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);

        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.05f);

        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
