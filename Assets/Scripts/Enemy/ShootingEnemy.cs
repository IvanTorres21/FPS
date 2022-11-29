using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    private GameObject cannon;
    private GameObject cannonAxis;
    private GameObject player;
    [SerializeField] private GameObject bullet;
    private PlayerTimeController playerTimeController;

    private float shootTime = 0.4f;
    private bool reloading = false;
    private bool isShooting = false;

    private void Start()
    {
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        cannonAxis = transform.GetChild(0).gameObject;
        cannon = cannonAxis.transform.GetChild(0).gameObject;
        player = GameObject.Find("Player");

    }

    private void Update()
    {
        if(!playerTimeController.isTimePaused)
        {
            SeekPlayer();
            if (isShooting)
            {
                ShootPlayer();
            }
        }
    }

    private void ShootPlayer()
    {
     
    }

    private void SeekPlayer()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 40 && transform.position.y + 7f > player.transform.position.y)
        {
            isShooting = true;
        } else if(isShooting)
        {
            isShooting = false;
        }

        if(isShooting)
        {
            cannonAxis.transform.LookAt(player.transform);
            if(CheckPlayerInSight() && !reloading)
            {
                reloading = true;
                GameObject currentBullet = Instantiate(bullet, cannon.transform.GetChild(0).transform.position, cannon.transform.rotation, GameObject.Find("EnemyBulletPool").transform);
                currentBullet.GetComponent<Rigidbody>().velocity = cannon.transform.GetChild(0).transform.forward * currentBullet.GetComponent<BulletController>().speed;
                StartCoroutine(ReloadGun());
            }
            
        }
    }

    IEnumerator ReloadGun()
    {
        yield return new WaitForSeconds(shootTime);
        reloading = false;
    }

    private bool CheckPlayerInSight()
    {
        Ray ray = new Ray(cannon.transform.position, cannon.transform.forward);
        if (Physics.Raycast(ray, Mathf.Infinity, 1 << 3))
            return true;
        else
            return false;
    }
}
