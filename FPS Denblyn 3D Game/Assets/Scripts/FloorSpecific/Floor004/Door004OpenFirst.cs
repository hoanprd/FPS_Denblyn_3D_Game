using System.Collections;
using System.Collections.Generic;
//using UnityEditor.VersionControl;
using UnityEngine;

public class Door004OpenFirst : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorFX.Play();
            theDoor.GetComponent<Animator>().Play("door_2_open");
            this.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(CloseDoor());
        }
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(4);
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("door_2_close");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
