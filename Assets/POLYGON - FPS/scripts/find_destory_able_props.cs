using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_destory_able_props : MonoBehaviour
{

    // general keeping of active props, that we don't have to search all the time, add here new porps, also these, which you spawned

   public GameObject[] objs_1;
    public GameObject[] objs_2;
    public GameObject[] objs_3;

    public GameObject[] objs_4;
    public GameObject[] objs_5;
    public GameObject[] objs_6;
    public List<Transform> objs_7 = new List<Transform>();






    void Start()
    {
        // searching objects to add them to the list
        // objs_1 = GameObject.FindGameObjectsWithTag("door");
         objs_2 = GameObject.FindGameObjectsWithTag("metall_door");
         objs_3 = GameObject.FindGameObjectsWithTag("wood_door");
         objs_4 = GameObject.FindGameObjectsWithTag("wood");
         objs_5= GameObject.FindGameObjectsWithTag("glass");
         objs_6 = GameObject.FindGameObjectsWithTag("petrol");
         






    }

    
}
