using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    public GameObject Message;
    public bool IsActive = false;
    public bool Actived = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && IsActive == true)
        {
            Actived = true;
            Message.GetComponent<Text>().text = "Control panel actived";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsActive = true;
            Message.SetActive(true);
            if (Actived == false)
                Message.GetComponent<Text>().text = "Nhấn 'F' để kích hoạt bảng điều khiển";
            else
                Message.GetComponent<Text>().text = "Bảng điều khiển đã kích hoạt!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsActive = false;
        Message.SetActive(false);
    }
}
