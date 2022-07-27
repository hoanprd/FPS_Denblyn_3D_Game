using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public GameObject thePlayer;
    public AudioSource clickSound;
    public GameObject fadeOut;
    public int loadScene;
    public int loadHealth;
    public int loadLives;
    public int loadScore;
    public int loadHandGun;
    public int loadMachineGun;
    public int loadHGAmmo;
    public int loadMGAmmo;

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        GlobalLife.lifeValue = 3;
        GlobalScore.scoreValue = 0;
        GlobalAmmo.machinegunAmmo = 0;
        GlobalAmmo.handgunAmmo = 0;
        GlobalWeapons.MachineGun = 0;
        GlobalWeapons.HandGun = 0;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }

    public void LoadGame()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad");
        if (loadScene == 0)
        {
            //null
        }
        else
            StartCoroutine(LoadGameRoutine());
    }

    IEnumerator LoadGameRoutine()
    {
        clickSound.Play();
        loadHealth = PlayerPrefs.GetInt("HealthSaved");
        loadLives = PlayerPrefs.GetInt("LifeSaved");
        loadScore = PlayerPrefs.GetInt("ScoreSaved");
        loadMachineGun = PlayerPrefs.GetInt("MachineGunSaved");
        loadHandGun = PlayerPrefs.GetInt("HandGunSaved");
        loadMGAmmo = PlayerPrefs.GetInt("MGAmmoSaved");
        loadHGAmmo = PlayerPrefs.GetInt("HGAmmoSaved");
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);

        GlobalComplete.nextFloor = loadScene;
        GlobalLife.lifeValue = loadLives;
        GlobalScore.scoreValue = loadScore;
        GlobalAmmo.machinegunAmmo = loadMGAmmo;
        GlobalAmmo.handgunAmmo = loadHGAmmo;
        GlobalWeapons.MachineGun = loadMachineGun;
        GlobalWeapons.HandGun = loadHandGun;
        SceneManager.LoadScene(loadScene);
    }

    public void ResetGame()
    {
        clickSound.Play();
        PlayerPrefs.SetInt("SceneToLoad", 0);
        PlayerPrefs.SetInt("HealthSaved", 0);
        PlayerPrefs.SetInt("LifeSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("HandGunSaved", 0);
        PlayerPrefs.SetInt("MachineGunSaved", 0);
        PlayerPrefs.SetInt("MGAmmoSaved", 0);
        PlayerPrefs.SetInt("HGAmmoSaved", 0);
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        clickSound.Play();
        Application.Quit();
    }
}
