using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTimeController : MonoBehaviour
{
    private PlayerTimeController timeController;
    private ParticleSystem particle;
    private bool hasBeenPaused = false;

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        timeController = FindObjectOfType<PlayerTimeController>();

    }

    private void Update()
    {
        var main = particle.main;
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

        if (particle.isStopped) Destroy(this.gameObject);
    }

}
