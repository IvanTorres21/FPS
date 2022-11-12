using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncherController : MonoBehaviour
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
    [SerializeField] private int current_ammo = 1;
    [SerializeField] private int max_ammo = 1;
    [SerializeField] private GameObject FakeBullet;

    private AudioSource shootSound;

    [SerializeField] private RecoilScript recoilScript;

    private void Start()
    {
        //shootSound = GetComponent<AudioSource>();
        bulletPool = GameObject.Find("BulletPool");
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
        }
        else if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = waistPosition;
        }

    }

    private IEnumerator reloadGun()
    {
        isReloading = true;
        yield return new WaitForSecondsRealtime(reloadingSpeed);
        FakeBullet.SetActive(true);
        current_ammo = max_ammo;
        isReloading = false;
    }

    private IEnumerator shootBullet()
    {
        
        //shootSound.Play();
        isShooting = true;
        current_ammo--;
        FakeBullet.SetActive(false);
        GameObject currentBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation, bulletPool.transform);
        currentBullet.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * currentBullet.GetComponent<MissileController>().speed;
        yield return new WaitForSecondsRealtime(shootingSpeed);
        isShooting = false;
    }
}
