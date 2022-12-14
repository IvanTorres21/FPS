using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RocketLauncherController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public GameObject bulletPool;
    private bool isShooting = false;
    public bool isReloading = false;

    [SerializeField] private Vector3 aimPosition;
    [SerializeField] private Vector3 waistPosition;
    [SerializeField] private bool isAutomatic;
    [SerializeField] private float shootingSpeed;
    [SerializeField] private float reloadingSpeed;
    [SerializeField] private int current_ammo = 1;
    [SerializeField] private int max_ammo = 1;
    [SerializeField] private GameObject FakeBullet;
    [SerializeField] private int total_ammo = 4;
    [SerializeField] private TextMeshProUGUI ammoText;
    [SerializeField] private TextMeshProUGUI needToReloadText;
    [SerializeField] private AudioSource shootSound;
    [SerializeField] private AudioSource reloadingSound;

    [SerializeField] private RecoilScript recoilScript;

    private void Start()
    {
        bulletPool = GameObject.Find("BulletPool");
        SetAmmoText();
    }

    public void SetAmmoText()
    {
        if (current_ammo <= 0)
        {
            needToReloadText.gameObject.SetActive(true);
        } else
        {
            needToReloadText.gameObject.SetActive(false);
        }
        ammoText.text = current_ammo + "/" + total_ammo;
    }

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) && !isShooting && current_ammo != 0 & !isReloading) || (isAutomatic && Input.GetMouseButton(0) && !isShooting && current_ammo != 0 & !isReloading))
        {
            StartCoroutine(shootBullet());
        }
        if (Input.GetKeyDown(KeyCode.R) && total_ammo != 0)
        {
            StartCoroutine(reloadGun());
        }
        else if (Input.GetMouseButton(1))
        {
            transform.localPosition = aimPosition;
            GetComponent<RecoilScript>().initialGunPosition = aimPosition;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = waistPosition;
            GetComponent<RecoilScript>().initialGunPosition = waistPosition;
        }

    }

    private IEnumerator reloadGun()
    {
        isReloading = true;
        reloadingSound.Play();
        yield return new WaitForSecondsRealtime(reloadingSpeed);
        FakeBullet.SetActive(true);
        int ammo_needed = max_ammo - current_ammo;
        if(total_ammo < ammo_needed)
        {
            current_ammo = total_ammo;
            total_ammo = 0;
        } else
        {
            current_ammo = max_ammo;
            total_ammo -= ammo_needed;
        }
        SetAmmoText();
        isReloading = false;
    }

    private IEnumerator shootBullet()
    {
        recoilScript.recoil();
        shootSound.Play();
        current_ammo--;
        SetAmmoText();
        FakeBullet.SetActive(false);
        GameObject currentBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation, bulletPool.transform);
        currentBullet.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * currentBullet.GetComponent<MissileController>().speed;
        yield return new WaitForSecondsRealtime(shootingSpeed);
    }
}
