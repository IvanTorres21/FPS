using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormGuide : MonoBehaviour
{
    private int hp = 600;
    [SerializeField] private bool isDigging;
    [SerializeField] private bool isAttacking;
    [SerializeField] private GameObject referencePoint;
    private PlayerTimeController playerTimeController;
    private float speed = 12f;

    private Rigidbody rb;

    [SerializeField] private List<Ray> sphereRay = new List<Ray>();
    private Vector3 closestPoint;
    [SerializeField] private float closestDistance;
    [SerializeField] private Vector3 nextPoint = Vector3.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        StartCoroutine(ControlBehaviour());
    }

    private void Update()
    {
        
        rb.velocity = transform.forward.normalized * speed * playerTimeController.slowdown;
    }

    private void CheckForClosestPoint()
    {
        isDigging = true;
        sphereRay.Clear();
        closestDistance = 1000f;
        for (int i = 0; i < 9; i++)
        {
            float degreeS = (i / 8f) * 360;
            for(int j = 0; j < 9; j++)
            {
                float degreeT = (j / 8f) * 360;
                RaycastHit hit;
                if (Physics.Raycast(new Ray(transform.position, (transform.position + GetPointInSphere(degreeS, degreeT, 5)).normalized), out hit))
                {
                    Debug.Log(hit.distance);
                    if (hit.distance < closestDistance)
                    {
                        closestDistance = hit.distance;
                        closestPoint = hit.point;
                    }
                }
            }
        }
        nextPoint = closestPoint;
        transform.LookAt(nextPoint);
    }

    private Vector3 GetPointInSphere(float s, float t, float r)
    {
        s = Mathf.Deg2Rad * s;
        t = Mathf.Deg2Rad * t;
        Vector3 point = new Vector3();
        point.x = r * Mathf.Cos(s) * Mathf.Sin(t);
        point.y = r * Mathf.Sin(s) * Mathf.Sin(t);
        point.z = r * Mathf.Cos(t);
        return point;
    }

    IEnumerator ControlBehaviour()
    {
        while (hp >= 0)
        {
            if(!isDigging)
            {
                CheckForClosestPoint();             
            }
            yield return new WaitForSeconds(1f);
        }
        yield return null;
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(2f);
        isDigging = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(isDigging && other.CompareTag("Ground"))
        {
            StartCoroutine(ChangeDirection());
        }
    }
}
