using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallBouncer : MonoBehaviour
{

    [SerializeField]
    private float speed = 0.4f;

    private Vector3 velocity;
    private Rigidbody rb;

    private bool padFound = true;

    public void OnPadFound()
    {
        padFound = true;
    }

    public void OnPadLost()
    {
        padFound = false;
    }

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        velocity = Vector3.forward * 0.05f + Vector3.left * 0.06f;
    }

    private void Update()
    {
        rb.velocity = padFound ? velocity : Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var direction = Vector3.Reflect(velocity.normalized, collisionNormal);
        velocity = direction * speed;
    }
}