using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;
    public GameObject bulletPool;
    private int current_ammo = 7;
    private int max_ammo = 7;
    private bool isShooting = false;
    private bool isReloading = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isShooting && current_ammo != 0 & !isReloading)
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
        yield return new WaitForSecondsRealtime(1f);
        current_ammo = max_ammo;
        isReloading = false;
    }

    private IEnumerator shootBullet()
    {
        isShooting = true;
        current_ammo--;
        GameObject currentBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation, bulletPool.transform);
        currentBullet.GetComponent<Rigidbody>().velocity = spawnPoint.transform.forward * currentBullet.GetComponent<BulletController>().speed;
        yield return new WaitForSecondsRealtime(0.3f);
        isShooting = false;
    }
}
