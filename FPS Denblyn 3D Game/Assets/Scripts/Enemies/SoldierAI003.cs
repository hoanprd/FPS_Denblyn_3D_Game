using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI003 : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    //public GameObject hurtFlash;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 0.2f;
    public int getHurt;
    public int recoil;
    public AudioSource[] hurtSound;

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire2());
        }
        else if (hitTag != "Player")
        {
            theSoldier.GetComponent<Animator>().Play("demo_combat_idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire2()
    {
        isFiring = true;

        // Animation + sound
        //theSoldier.GetComponent<Animator>().Play("demo_combat_shoot", -1, 0);
        //theSoldier.GetComponent<Animator>().Play("demo_combat_shoot");
        theSoldier.GetComponent<Animator>().Play("demo_combat_run");
        fireSound.Play();
        lookingAtPlayer = true;

        // Instantiate bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Vector3 shootDir = firePoint.forward;
        bullet.GetComponent<EnemyBullet>().Init(shootDir, bulletSpeed);

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }

    /*IEnumerator EnemyFire()
    {
        isFiring = true;
        //theSoldier.GetComponent<Animator>().Play("demo_combat_shoot", -1, 0);
        //theSoldier.GetComponent<Animator>().Play("demo_combat_shoot");
        theSoldier.GetComponent<Animator>().Play("demo_combat_run");
        fireSound.Play();
        lookingAtPlayer = true;
        recoil = Random.Range(0, 3);
        if (recoil == 0)
        {
            GlobalHealth.healthValue -= 5;
            getHurt = Random.Range(0, 3);
            hurtSound[getHurt].Play();
            //hurtFlash.SetActive(true);
            yield return new WaitForSeconds(0.05f);

            //hurtFlash.SetActive(false);
        }
        else
        {
            //null
        }
        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }*/
}
