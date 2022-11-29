using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperAimController : MonoBehaviour
{
    [SerializeField] private float AIM_FOV = 30;
    [SerializeField] private float BASE_FOV = 86;
    [SerializeField] private GameObject model;
    [SerializeField] private GameObject crosshair;
    [SerializeField] private bool isSniper = false;
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            
            StartCoroutine(TakeAim());
        }
        if (Input.GetMouseButtonUp(1))
        {
            StopAllCoroutines();
            Camera.main.fieldOfView = BASE_FOV;
            if (isSniper)
            {
                crosshair.SetActive(false);
                model.SetActive(true);
            }
        }
    }

    private IEnumerator TakeAim()
    {
        do
        {
            Camera.main.fieldOfView -= 1;
            
            if (isSniper && Camera.main.fieldOfView <= 50)
            {
                crosshair.SetActive(true);
                model.SetActive(false);
            }
            yield return new WaitForSeconds(0.0005f);
        } while (Camera.main.fieldOfView > AIM_FOV && Input.GetMouseButton(1));
        
        
    }
}
