using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PlayerTimeController : MonoBehaviour
{
    [SerializeField] public bool isTimePaused { get; private set; } = false;
    [SerializeField] public float slowdown { get; private set; } = 1f;
    [SerializeField] private float magicLeft = 1000;

    [SerializeField] private MeshRenderer soulgem;
    private Color newColor;

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
                StartCoroutine(BringTimeBack());
            }
            else
            {
                StartCoroutine(SlowTimeDown());
            }
        }
    }

    private void UpdateCurrentMagic()
    {
        newColor = new Color(210 * (magicLeft / 1000), 0, 255 * (magicLeft / 1000));
        soulgem.material.SetColor("_BaseColor", newColor);
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
            if(magicLeft > 0)
            {
                magicLeft -= 1f;
            } else
            {
                isTimePaused = false;
            }
            UpdateCurrentMagic();
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
}
