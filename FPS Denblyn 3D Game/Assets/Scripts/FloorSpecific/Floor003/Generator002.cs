﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator002 : MonoBehaviour
{
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            Actived = true;
            Platform002.Gen1 = true;
            Message.GetComponent<Text>().text = "Máy phát đã kích hoạt!";
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

    /*void OnCollisionExit(Collision collision)
    {
        IsActive = false;
        Message.SetActive(false);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsActive = true;
            Message.SetActive(true);
            if (Actived == false)
                Message.GetComponent<Text>().text = "Nhấn 'F' để kích hoạt máy phát";
            else
                Message.GetComponent<Text>().text = "Máy phát đã kích hoạt!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
