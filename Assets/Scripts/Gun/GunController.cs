using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public GameObject bulletPool;
    private bool isShooting = false;
    private bool isReloading = false;

    [SerializeField] private bool isAutomatic;
    [SerializeField] private float shootingSpeed;
    [SerializeField] private float reloadingSpeed;
    [SerializeField] private int current_ammo = 7;
    [SerializeField] private int max_ammo = 7;

    [SerializeField] private RecoilScript recoilScript;
    private void Update()
    {
        if((Input.GetMouseButtonDown(0) && !isShooting && current_ammo != 0 & !isReloading) || (isAutomatic && Input.GetMouseButton(0) && !isShooting && current_ammo != 0 & !isReloading))
        {
            StartCoroutine(shootBullet());
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reloadGun());
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
        isShooting = true;
        recoilScript.recoil();
        current_ammo--;
        GameObject currentBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation, bulletPool.transform);
        currentBullet.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * currentBullet.GetComponent<BulletController>().speed;
        yield return new WaitForSecondsRealtime(shootingSpeed);
        isShooting = false;
    }
}
