using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperAimController : MonoBehaviour
{
    private const float AIM_FOV = 30;
    private const float BASE_FOV = 86;
    [SerializeField] private GameObject model;
    [SerializeField] private GameObject crosshair;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            
            StartCoroutine(TakeAim());
        } else if(Input.GetMouseButtonUp(1))
        {
            StopCoroutine(TakeAim());
            Camera.main.fieldOfView = BASE_FOV;
            crosshair.SetActive(false);
            model.SetActive(true);
        }
    }

    private IEnumerator TakeAim()
    {
        yield return new WaitForSeconds(0.1f);
        crosshair.SetActive(true);
        model.SetActive(false);
        Camera.main.fieldOfView = AIM_FOV;
    }
}
