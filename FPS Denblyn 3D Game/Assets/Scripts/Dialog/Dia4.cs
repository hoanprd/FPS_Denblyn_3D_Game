using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia4 : MonoBehaviour
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
            DiaText.GetComponent<Text>().text = "Morro: Alia, tôi đã nhặt được và đọc nhật ký của một người lính canh ở đây.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: Vậy thì sao? Có manh mối nào không?";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: Họ có nhiệm vụ chung là trông chừng trẻ em và ngăn chặn người ngoài xâm nhập.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: Trẻ con?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tôi bắt đầu nghi ngờ rằng những đứa trẻ này đã bị đưa vào thí nghiệm đột biến.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: Không đời nào, vũ khí sinh học là một tội ác khủng khiếp.";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tôi biết đó là lý do tại sao tôi tiết lộ sự thật về nhiệm vụ này. Tôi nghĩ bọn trẻ bị nhốt ở tầng cao nhất của lâu đài.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Morro: Còn một điều nữa! Xin hãy gửi một chiếc trực thăng đến đây trong vòng một giờ.";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Alia: Tôi hiểu rồi!";
        }
        if (dem == 10)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
