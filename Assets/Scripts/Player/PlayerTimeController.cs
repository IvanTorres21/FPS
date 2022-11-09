using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeController : MonoBehaviour
{
    public bool isTimePaused = false;
    public float slowdown = 1f;
    public float magicLeft = 200;

    public GameObject soulgem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StopAllCoroutines();
            isTimePaused = !isTimePaused;
            if (!isTimePaused)
            {
                slowdown = 1f;
            }
            else
            {
                StartCoroutine(SlowTimeDown());
            }
        }
        if (!isTimePaused)
        {
            slowdown = 1f;
        }

        UpdateCurrentMagic();
    }

    private void UpdateCurrentMagic()
    {
        Color newEmmission = new Color(212 * (magicLeft / 200), 0, 255 * (magicLeft / 200));
        soulgem.GetComponent<Renderer>().material.SetColor("_Color", newEmmission);
    }

    IEnumerator SlowTimeDown()
    {
        while(slowdown > 0f)
        {
            slowdown -= 0.1f;
            yield return new WaitForSeconds(0.05f);
            if(slowdown < 0f) slowdown = 0f;
        }

        while(isTimePaused)
        {
            magicLeft -= 1f;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
