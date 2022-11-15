using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBossFight : MonoBehaviour
{
    [SerializeField] private GameObject worm;
    [SerializeField] private GameObject bossHP;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            worm.SetActive(true);
            bossHP.SetActive(true);
        }
    }
}
