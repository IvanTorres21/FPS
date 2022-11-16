using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormFollowBody : MonoBehaviour
{
    [SerializeField] private GameObject wormGuide;
    [SerializeField] private List<GameObject> segments;
    private PlayerTimeController playerTimeController;
    private void Start()
    {
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        foreach(Transform segment in transform)
        {
            if(segment.name.Contains("Segment"))
            {
                segments.Add(segment.gameObject);
            }
        }
    }

    private void Update()
    {
        LookAtSegments();
    }

    private void LookAtSegments()
    {
        for (int i = 0; i < segments.Count; i++)
        {
            if (i == 0)
            {
                segments[i].transform.LookAt(wormGuide.transform);
                
            }
            else
            {
                segments[i].transform.LookAt(segments[i - 1].transform);
            }
        }
    }

}
