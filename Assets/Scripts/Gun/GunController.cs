using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public GameObject bulletPool;
    private bool isShooting = false;
    private bool isReloading = false;

    [SerializeField] private Vector3 aimPosition;
    [SerializeField] private Vector3 waistPosition;
    [SerializeField] private bool isAutomatic;
    [SerializeField] private float shootingSpeed;
    [SerializeField] private float reloadingSpeed;
    [SerializeField] private int current_ammo = 7;
    [SerializeField] private int max_ammo = 7;

    private AudioSource shootSound;

    [SerializeField] private RecoilScript recoilScript;

    private void Start()
    {
        shootSound = GetComponent<AudioSource>();
        bulletPool = GameObject.Find("BulletPool");
    }

    private void Update()
    {
        if((Input.GetMouseButtonDown(0) && !isShooting && current_ammo != 0 & !isReloading) || (isAutomatic && Input.GetMouseButton(0) && !isShooting && current_ammo != 0 & !isReloading))
        {
            StartCoroutine(shootBullet());
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reloadGun());
        } else if (Input.GetMouseButton(1))
        {
            transform.localPosition = aimPosition;
            GetComponent<RecoilScript>().initialGunPosition = aimPosition;
        } else if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = waistPosition;
            GetComponent<RecoilScript>().initialGunPosition = waistPosition;
        }

    }

    private IEnumerator reloadGun()
    {
        isReloading = true;
        yield return new WaitForSecondsRealtime(reloadingSpeed);
        current_ammo = max_ammo;
        isReloading = false;
    }

    private IEnumerator shootBullet()
    {
        shootSound.Play();
        isShooting = true;
        recoilScript.recoil();
        current_ammo--;
        GameObject currentBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation, bulletPool.transform);
        currentBullet.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * currentBullet.GetComponent<BulletController>().speed;
        yield return new WaitForSecondsRealtime(shootingSpeed);
        isShooting = false;
    }
}
