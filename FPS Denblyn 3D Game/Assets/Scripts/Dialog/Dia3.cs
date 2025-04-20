using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia3 : MonoBehaviour
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
            DiaText.GetComponent<Text>().text = "Morro: Alia! Đã rõ hơn chưa?";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: Tôi nghe rồi.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tốt! Tôi đã đến tầng trệt của lâu đài, có vẻ như có rất nhiều lính ở đây.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: Vậy bạn nghĩ họ thực sự sản xuất vũ khí chiến tranh sao?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Vâng, tôi sẽ tìm kiếm bằng chứng cũng như tài liệu về việc này.";
        }
        if (dem == 6)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
