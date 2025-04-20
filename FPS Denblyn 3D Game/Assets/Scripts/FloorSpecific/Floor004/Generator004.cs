using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generator004 : MonoBehaviour
{
    Door004OpenSecond DOS;
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Start is called before the first frame update
    void Start()
    {
        DOS = FindObjectOfType<Door004OpenSecond>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            Actived = true;
            DOS.Gen4 = true;
            Message.GetComponent<Text>().text = "Máy phát đã kích hoạt!";
        }
    }

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
