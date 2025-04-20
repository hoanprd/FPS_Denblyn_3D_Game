using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia2 : MonoBehaviour
{
    public GameObject DiaText;
    public int dem = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            dem++;
        }

        if (dem == 1)
        {
            DiaText.GetComponent<Text>().text = "Morro: Được rồi, đây hẳn là lối vào tầng hầm của lâu đài.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Enemy: Có kẻ xâm nhập!";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Tiếng súng RPG bắn ra.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Morro: Cái gì!";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Boommmmm";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "1 tiếng sau";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Alia! Bạn có nghe thấy tôi không?";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Alia: ... Tín hiệu... rất là... yếu...";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: Được rồi, tôi sẽ lên lầu để dễ nói chuyện hơn.";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "Morro: May mắn thay, tôi đã thoát chết ngay lập tức và đột nhập thành công vào tầng hầm, toàn bộ vũ khí đã biến mất.";
        }
        if (dem == 11)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
