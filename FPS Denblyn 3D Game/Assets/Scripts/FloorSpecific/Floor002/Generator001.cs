using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Generator001 : MonoBehaviour
{
    public GameObject Elevator;
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true && VisaCardPickUp.CardActived == true)
        {
            Actived = true;
            Elevator.GetComponent<Animator>().enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.F) && IsActive == true && VisaCardPickUp.CardActived == false)
        {
            //Message.GetComponent<Text>().text = "You need the visa card!";
            Message.GetComponent<Text>().text = "Cần thẻ visa để kích hoạt!";
        }
    }

    /*private void OnCollisionEnter()
    {
        IsActive = true;
        Message.SetActive(true);
        if (Actived == false)
            Message.GetComponent<Text>().text = "Press 'F' to active the elevator";
        else
            Message.GetComponent<Text>().text = "Elevator actived";
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsActive = true;
            Message.SetActive(true);
            if (Actived == false)
                Message.GetComponent<Text>().text = "Nhấn 'F' để kích hoạt thang máy";
            else
                Message.GetComponent<Text>().text = "Thang máy đã kích hoạt!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsActive = false;
        Message.SetActive(false);
    }

    /*private void OnCollisionExit()
    {
        Message.SetActive(false);
    }*/
}
