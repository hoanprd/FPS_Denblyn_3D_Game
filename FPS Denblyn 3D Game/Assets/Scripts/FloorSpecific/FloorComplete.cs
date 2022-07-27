using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);
        GlobalComplete.nextFloor += 1;
        yield return new WaitForSeconds(2);

        completePanel.SetActive(true);
        yield return new WaitForSeconds(8);

        GlobalScore.scoreValue = 0;
        GlobalComplete.killsCount = 0;
        GlobalComplete.treasureCount = 0;
        
        SceneManager.LoadScene(GlobalComplete.nextFloor);
    }
}
