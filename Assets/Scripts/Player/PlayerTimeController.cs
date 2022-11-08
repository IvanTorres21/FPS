using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeController : MonoBehaviour
{
    bool isTimePaused = false;
    public float slowdown = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
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
    }

    IEnumerator SlowTimeDown()
    {
        while(slowdown > 0f)
        {
            slowdown -= 0.1f;
            yield return new WaitForSeconds(0.05f);
            if(slowdown < 0f) slowdown = 0f;
        }
    }
}
