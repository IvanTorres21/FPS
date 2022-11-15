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
    }

    private void Update()
    {
        if(!playerTimeController.isTimePaused)
        {
            LookAtSegments();
        }
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
