using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalWeapons : MonoBehaviour
{
    public GameObject realHandGun;
    public GameObject pistolImage;
    public GameObject realMachineGun;
    public GameObject AK47Image;
    public static int HandGun;
    public static int MachineGun;

    void Start()
    {
        if (HandGun == 1)
        {
            realHandGun.SetActive(true);
            pistolImage.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1) && MachineGun == 1)
        {
            realHandGun.SetActive(false);
            pistolImage.SetActive(false);
            realMachineGun.SetActive(true);
            AK47Image.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2) && HandGun == 1)
        {
            realHandGun.SetActive(true);
            pistolImage.SetActive(true);
            realMachineGun.SetActive(false);
            AK47Image.SetActive(false);
        }
    }
}
