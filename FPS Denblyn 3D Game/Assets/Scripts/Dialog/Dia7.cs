using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia7 : MonoBehaviour
{
    public GameObject Dialog7;
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
            DiaText.GetComponent<Text>().text = "Morro: Alia! Bạn có nghe thấy tôi không!";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: Có! Tôi có thể nghe thấy bạn!";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tôi đã giải cứu thành công bọn trẻ!";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: Tuyệt quá, trực thăng sẽ tới đó trong vài phút nữa!";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Ồ, tôi hiểu rồi.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Tiếng trực thăng";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Đây chưa phải là kết thúc, những đứa trẻ này vẫn đang bị sử dụng làm vũ khí cho mục đích kết thúc chiến tranh thế giới.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Người lính đồng minh: Cậu ổn chứ, Morro! Tôi không ngờ cậu lại hoàn thành được nhiệm vụ bất khả thi này!";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: Vâng, tôi ổn. (Trận chiến chỉ mới bắt đầu)";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "Kết thúc!";
        }
        if (dem == 11)
        {
            SceneManager.LoadScene(14);
        }
    }
}
