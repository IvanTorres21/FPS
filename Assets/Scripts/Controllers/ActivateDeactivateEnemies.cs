using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateEnemies : MonoBehaviour
{
    [SerializeField] private bool activator = false;

    [SerializeField] private List<GameObject> objects;

    [SerializeField] private bool stopsMusic;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            foreach (GameObject item in objects)
            {
                item.SetActive(activator);
            }

            if(stopsMusic)
            {
                GameObject.Find("MusicManager").GetComponent<AudioSource>().Stop();
            }
        }
    }
}
