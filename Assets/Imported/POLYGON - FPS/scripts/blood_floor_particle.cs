using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood_floor_particle : MonoBehaviour
{



    public GameObject Blood_decal;

    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;
    public GameObject recyle_particles_performance;

    private void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();

        // reusing a used particle, to save spawn perfromance

        recyle_particles_performance = GameObject.FindGameObjectWithTag("rycle");
    }





    void OnParticleCollision(GameObject other)
    {
    
        // getting collision events to spawn on the hit point a blood decal

       
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);



        int i = 0;
        
        while (i < numCollisionEvents)
        {
            if (other.gameObject.tag != "Untagged" && other.gameObject.tag != "body" && other.gameObject.tag != "Player" && other.gameObject.tag != "blood" && other.gameObject.tag != "8x8")
            {
                Vector3 pos = collisionEvents[i].intersection;
                Vector3 force = collisionEvents[i].velocity * 10;

                // sending location of blood hit to the script, which handle to replace decal, because they don't spawn again on the point
                recyle_particles_performance.GetComponent<recyle_inst>().blood_decal_new(collisionEvents[i].intersection, collisionEvents[i].normal);


            }
            i++;
        }





    }














    }
