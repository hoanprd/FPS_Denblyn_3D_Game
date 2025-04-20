using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dia1 : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    public GameObject DiaText;
    public int dem = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            dem++;
        }

        /*if (dem == 1)
        {
            DiaText.GetComponent<Text>().text = "After World War II, fascist Japan lost the battle miserably.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "But there are some erratic rumors about an Osas castle in Japan researching weapons of war.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "At this time, a brave American soldier took on the task of breaking into this citadel.";
        }
        if (dem == 4)
        {
            Image1.SetActive(false);
            Image2.SetActive(true);
            DiaText.GetComponent<Text>().text = "Alia: Morro! Can you hear me?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Uhm! I listen, as well as ready for this mission.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: I didn't expect you to accept this impossible mission, especially a soldier who retired after World War II.";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: It was only because of the rumors that they researched weapons of war that I came to confirm.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Alia: But no one has ever returned from breaking into that castle alive.";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: Alia, I have nothing left to lose after the war.";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "Alia: You're so stubborn.";
        }
        if (dem == 11)
        {
            DiaText.GetComponent<Text>().text = "Morro: Okay I'm outside the castle, I'll call back when I get into the castle.";
        }
        if (dem == 12)
        {
            DiaText.GetComponent<Text>().text = "Alia: Good luck!";
        }*/

        if (dem == 1)
        {
            DiaText.GetComponent<Text>().text = "Sau Thế chiến II, phát xít Nhật Bản đã thua thảm hại.";
        }
        if (dem == 2)
        {
            DiaText.GetComponent<Text>().text = "Nhưng có một số tin đồn thất thường về một lâu đài Osas ở Nhật Bản đang nghiên cứu vũ khí chiến tranh.";
        }
        if (dem == 3)
        {
            DiaText.GetComponent<Text>().text = "Vào thời điểm đó, một người lính Mỹ dũng cảm đã đảm nhận nhiệm vụ đột nhập vào thành trì này.";
        }
        if (dem == 4)
        {
            Image1.SetActive(false);
            Image2.SetActive(true);
            DiaText.GetComponent<Text>().text = "Alia: Morro! Anh có nghe thấy tôi không?";
        }
        if (dem == 5)
        {
            DiaText.GetComponent<Text>().text = "Morro: Ừm! Tôi lắng nghe và sẵn sàng cho nhiệm vụ này.";
        }
        if (dem == 6)
        {
            DiaText.GetComponent<Text>().text = "Alia: Tôi không ngờ anh lại chấp nhận nhiệm vụ bất khả thi này, đặc biệt là một người lính đã nghỉ hưu sau Thế chiến thứ II.";
        }
        if (dem == 7)
        {
            DiaText.GetComponent<Text>().text = "Morro: Tôi chỉ đến để xác nhận vì có tin đồn rằng họ đang nghiên cứu vũ khí chiến tranh.";
        }
        if (dem == 8)
        {
            DiaText.GetComponent<Text>().text = "Alia: Nhưng chưa có ai từng trở về sau khi đột nhập vào lâu đài đó.";
        }
        if (dem == 9)
        {
            DiaText.GetComponent<Text>().text = "Morro: Alia, tôi không còn gì để mất sau chiến tranh nữa.";
        }
        if (dem == 10)
        {
            DiaText.GetComponent<Text>().text = "Alia: Bạn thật là bướng bỉnh.";
        }
        if (dem == 11)
        {
            DiaText.GetComponent<Text>().text = "Morro: Được rồi, tôi đang ở bên ngoài lâu đài, tôi sẽ gọi lại khi vào trong lâu đài.";
        }
        if (dem == 12)
        {
            DiaText.GetComponent<Text>().text = "Alia: Chúc may mắn!";
        }
        if (dem == 13)
        {
            SceneManager.LoadScene(3);
        }
    }
}
