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
    private float speed = 1.0f;

    private Vector3 _velocity;
    private Rigidbody _rb;

    private bool padFound = true;
    
    private readonly Vector3 _startingVelocity =
        Vector3.forward * 0.05f + Vector3.left * 0.06f;

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
        _rb = GetComponent<Rigidbody>();
        _velocity = _startingVelocity;
    }

    private void Update()
    {
        _rb.velocity = padFound ? _velocity : Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var direction = Vector3.Reflect(_velocity.normalized, collisionNormal);
        _velocity = direction * speed;
    }
}