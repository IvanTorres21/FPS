using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class PlayerTimeController : MonoBehaviour
{
    [SerializeField] public bool isTimePaused { get; private set; } = false;
    [SerializeField] public float slowdown { get; private set; } = 1f;
    [SerializeField] private float magicLeft = 1000;
    [SerializeField] private Image magicBar;

    private bool canBeHit = true;
    [SerializeField] private Volume postProcessing;
    private ChromaticAberration cr;
    private FilmGrain fg;
    private WhiteBalance wb;

    private void Start()
    {
       if (postProcessing.profile.TryGet<ChromaticAberration>(out cr))
        {
            cr.intensity.value = 0f;
        } 
       if(postProcessing.profile.TryGet<FilmGrain>(out fg))
        {
            fg.intensity.value = 0f;
        }
       if(postProcessing.profile.TryGet<WhiteBalance>(out wb))
        {
            wb.temperature.value = 0f;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StopAllCoroutines();
            isTimePaused = !isTimePaused;
            if (!isTimePaused)
            {
                RestoreTime();
            }
            else
            {
                StartCoroutine(SlowTimeDown());
            }
        }

        UpdateMagicLeft();
    }

    private void UpdateMagicLeft()
    {
        magicBar.fillAmount = magicLeft / 1000;
    }

    private void RestoreTime()
    {
        StopAllCoroutines();
        StartCoroutine(BringTimeBack());
    }



    IEnumerator SlowTimeDown()
    {
        while(slowdown > 0f)
        {

            cr.intensity.value += 0.05f;
            fg.intensity.value += 0.05f;
            wb.temperature.value -= 1f;
            slowdown -= 0.05f;

            yield return new WaitForSeconds(0.05f);
            if(slowdown < 0f) slowdown = 0f;
        }

        while(isTimePaused)
        {
            if(magicLeft > 10)
            {
                magicLeft -= 1f;
            } else
            {
                isTimePaused = false;
                RestoreTime();
            }
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator BringTimeBack()
    {
        while (slowdown < 1f)
        {

            cr.intensity.value -= 0.05f;
            fg.intensity.value -= 0.05f;
            wb.temperature.value += 1f;
            slowdown += 0.05f;
            yield return new WaitForSeconds(0.05f);
        }

    }

    private void CheckHit(GameObject other)
    {
        Debug.Log("Ouchie");
        // I really should change this so that enemies have a standar controller with only useful data...
        SegmentController wg;
        if (other.TryGetComponent<SegmentController>(out wg))
        {
            this.magicLeft -= wg.damage;
            canBeHit = false;
        }
        BasicEnemyController be;
        if (other.TryGetComponent<BasicEnemyController>(out be))
        {
            this.magicLeft -= be.damage;
            canBeHit = false;
        }
        StartCoroutine(MakeInvulnerable());
    }

    IEnumerator MakeInvulnerable()
    {
        yield return new WaitForSeconds(0.4f);
        canBeHit = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Worm")) && canBeHit && !isTimePaused)
        {
            CheckHit(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Worm")) && canBeHit && !isTimePaused)
        {
            CheckHit(collision.gameObject);
        }
    }
}
