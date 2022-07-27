using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{
    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        GlobalLife.lifeValue -= 1;
        if (GlobalLife.lifeValue <= 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            if (GlobalComplete.nextFloor == 2)
                SceneManager.LoadScene(2);
            else
                SceneManager.LoadScene(GlobalComplete.nextFloor);
        }
    }
}
