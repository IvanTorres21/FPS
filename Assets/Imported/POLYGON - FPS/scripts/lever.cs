using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    public Texture emission_on;
    public Texture emission_off;

    public GameObject controlleed_door;
    public GameObject lever_mesh;

    public AudioClip click;


    bool door_status;

    public bool toggle_door;
    public void Update()
    {
        
    }

    public void Input()
    {

        // simple, checking of it is close, if as exampl yes, should it close and the door status get blocked, that it doesn't trigger back.  
        if(door_status == true)
        {
            door_status = false;

            // cahgning the light from red to green or in the other direction
             Material m = lever_mesh.GetComponent<Renderer>().materials[0];
            m.EnableKeyword("_EmissionMap");
            m.SetTexture("_EmissionMap", emission_on);
            AudioSource.PlayClipAtPoint(click, transform.position);

            controlleed_door.GetComponent<automatic_door>().Door_open();
        }
        else
        {
            door_status = true;

            Material m = lever_mesh.GetComponent<Renderer>().materials[0];
            m.EnableKeyword("_EmissionMap");
            m.SetTexture("_EmissionMap", emission_off);
            AudioSource.PlayClipAtPoint(click, transform.position);

            controlleed_door.GetComponent<automatic_door>().Door_close();
        }
        

    }
}
