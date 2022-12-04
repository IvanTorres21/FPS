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
    [SerializeField] private Image gotHit;

    private bool canBeHit = true;
    [SerializeField] private Volume postProcessing;
    public float alpha = 87f;
    private ChromaticAberration cr;
    private FilmGrain fg;
    private WhiteBalance wb;
    private Vignette vi;

    private bool hasDied = false;

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
       if(postProcessing.profile.TryGet<Vignette>(out vi))
        {
            vi.intensity.value = 0f;
        }
    }

    private void FixedUpdate()
    {
        ReturnAlpha();
    }

    private void Update()
    {
       if(magicLeft > 0)
        {
            
            if (Input.GetKeyDown(KeyCode.Z))
            {
                
                isTimePaused = !isTimePaused;
                if (!isTimePaused)
                {
                    RestoreTime();
                }
                else
                {
                    gameObject.GetComponent<AudioSource>().Play();
                    StopAllCoroutines();
                    StartCoroutine(SlowTimeDown());
                }
            }

            UpdateMagicLeft();
        }
    }

    private void UpdateMagicLeft()
    {
        magicBar.fillAmount = magicLeft / 2000f;
        vi.intensity.value = Mathf.Abs(((magicLeft / 2000) - 1) / 2);

    }

    private void RestoreTime()
    {
        StopAllCoroutines();
        StartCoroutine(BringTimeBack());
    }


    private void ReturnAlpha()
    {
        if(alpha > 0f)
        {
            alpha = gotHit.color.a;
            for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 1)
            {
                Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, 0, t));
                gotHit.color = newColor;
            }
        }

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

    public void CheckHit(GameObject other)
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
        BulletController bc;
        if(other.TryGetComponent<BulletController>(out bc))
        {
            this.magicLeft -= bc.damage;
            canBeHit = false;
        }
        alpha = 87f;
        gotHit.color = new Color(1, 1, 1, alpha);
        StartCoroutine(MakeInvulnerable());
        if(this.magicLeft <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if(!hasDied)
        {
            hasDied = true;
            Destroy(this.gameObject.GetComponent<PlayerMovementController>());
            Destroy(this.gameObject.transform.GetChild(1).GetChild(0).gameObject);
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            GameObject canvas = GameObject.Find("Canvas");

            // Activate reset button and all that jazz
            canvas.transform.GetChild(canvas.transform.childCount - 3).GetComponent<Animator>().Play("Fade");
            canvas.transform.GetChild(canvas.transform.childCount - 2).gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }

    }

    IEnumerator MakeInvulnerable()
    {
        yield return new WaitForSeconds(0.4f);
        canBeHit = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("EnemyBullet") || other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Worm")) && canBeHit && slowdown != 0f)
        {
            CheckHit(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("EnemyBullet") || collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Worm")) && canBeHit && slowdown != 0f)
        {
            CheckHit(collision.gameObject);
        }
    }

    public void MagicCheat()
    {
        magicLeft = 2000;
    }
}
