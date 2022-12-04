using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public GameObject bulletPool;
    public bool isShooting = false;
    public bool isReloading = false;

    [SerializeField] private Vector3 aimPosition;
    [SerializeField] private Vector3 waistPosition;
    [SerializeField] private bool isAutomatic;
    [SerializeField] private float shootingSpeed;
    [SerializeField] private float reloadingSpeed;
    [SerializeField] private int current_ammo = 7;
    [SerializeField] private int max_ammo = 7;
    [SerializeField] private int total_ammo = 200;
    [SerializeField] private TextMeshProUGUI ammoText;
    [SerializeField] private TextMeshProUGUI needToReloadText;

    [SerializeField] private AudioSource shootSound;
    [SerializeField] private AudioSource reloadingSound;

    [SerializeField] private RecoilScript recoilScript;

    private void Start()
    {
        bulletPool = GameObject.Find("BulletPool");
        recoilScript = GetComponent<RecoilScript>();
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
        if (Input.GetKeyDown(KeyCode.R))
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
        int ammo_needed = max_ammo - current_ammo;
        if (total_ammo < ammo_needed)
        {
            current_ammo = total_ammo;
            total_ammo = 0;
        }
        else
        {
            current_ammo = max_ammo;
            total_ammo -= ammo_needed;
        }
        isReloading = false;
        SetAmmoText();
    }

    private IEnumerator shootBullet()
    {

        shootSound.Play();
        isShooting = true;
        recoilScript.recoil();
        current_ammo--;
        SetAmmoText();
        
        GameObject currentBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation, bulletPool.transform);
        currentBullet.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * currentBullet.GetComponent<BulletController>().speed;
        yield return new WaitForSecondsRealtime(shootingSpeed);
        isShooting = false;
    }
}
