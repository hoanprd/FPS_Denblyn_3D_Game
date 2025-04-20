using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia5 : MonoBehaviour
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
            DiaText.GetComponent<Text>().text = "Morro: Alia, mọi việc thế nào rồi?";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Alia: Tôi đã cử một chiếc trực thăng tới đón anh.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tốt, tôi đã lên đến tầng cao nhất và nghe thấy tiếng trẻ con khóc rất to.";
        }
        if (dem == 4)
        {
            DiaText.GetComponent<Text>().text = "Alia: Họ thật tàn nhẫn!";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tôi cúp máy, có hàng chục kẻ thù đang đợi tôi ở bên ngoài.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: Đừng chết!";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tôi sẽ không chết cho đến khi bọn trẻ được tự do.";
        }
        if (dem == 8)
        {
            SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
