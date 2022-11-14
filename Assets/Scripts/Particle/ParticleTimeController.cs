using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTimeController : MonoBehaviour
{
    private PlayerTimeController timeController;
    private ParticleSystem particleSystem;
    private bool hasBeenPaused = false;

    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        timeController = FindObjectOfType<PlayerTimeController>();

    }

    private void Update()
    {
        var main = particleSystem.main;
        if (timeController.isTimePaused)
        {        
            main.simulationSpeed = timeController.slowdown;
            hasBeenPaused = true;
        }
        if (hasBeenPaused && !timeController.isTimePaused)
        {
            main.simulationSpeed = timeController.slowdown;
            
        };
        if(hasBeenPaused && main.simulationSpeed == 1)
        {
            hasBeenPaused = false;
        }

        if (particleSystem.isStopped) Destroy(this.gameObject);
    }

}
