using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeGunController : MonoBehaviour
{
    [SerializeField] List<GameObject> guns;
    [SerializeField] private int currentWeapon = 0;


    private void Start()
    {
        foreach(Transform gun in GameObject.Find("GunHolder").transform)
        {
            guns.Add(gun.gameObject);
        }
        changeWeapon();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)) {
            currentWeapon = currentWeapon++ % guns.Count;
            changeWeapon();
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
            changeWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
            changeWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
            changeWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentWeapon = 3;
            changeWeapon();
        }
    }

    private void changeWeapon()
    {
        foreach(GameObject gun in guns)
        {
            gun.SetActive(false);
        }

        guns[currentWeapon].SetActive(true);
        if(currentWeapon == 2)
        {
            guns[currentWeapon].GetComponent<RocketLauncherController>().SetAmmoText();
        } else
        {
            guns[currentWeapon].GetComponent<GunController>().SetAmmoText();
        }
    }
}
