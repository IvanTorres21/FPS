using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 45f;
    private bool justBorn = true;
    private Vector3 currentSpeed;
    private PlayerTimeController timeController;

    [SerializeField] public int damage { get; private set; } = 100;

    [SerializeField] private float blastRadius = 10f;
    [SerializeField] private float explosionForce = 300f;
    [SerializeField] private ParticleSystem explosionParticle;

    private Collider[] hitColliders;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = rb.velocity;
        timeController = FindObjectOfType<PlayerTimeController>();
        StartCoroutine(justShot());
    }


    private void Update()
    {
        if (!justBorn)
            rb.velocity = currentSpeed * timeController.slowdown;
    }

    IEnumerator justShot()
    {

        yield return new WaitForSeconds(0.05f);
        justBorn = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 contactPoint = collision.contacts[0].point;
        hitColliders = Physics.OverlapSphere(contactPoint, blastRadius);
        Instantiate(explosionParticle, contactPoint, Quaternion.identity);
        foreach (Collider col in hitColliders)
        {
            Debug.Log(col.gameObject.name);
           if(col.TryGetComponent<Rigidbody>(out rb))
            {
                col.GetComponent<Rigidbody>().isKinematic = false;
                col.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, contactPoint, blastRadius, 1, ForceMode.Impulse);
            }
            
        }

        Destroy(this.gameObject);
    }
}
