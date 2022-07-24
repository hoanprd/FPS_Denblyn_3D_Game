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
            SceneManager.LoadScene(2);
        }
    }
}
