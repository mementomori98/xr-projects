using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    void Start()
    {
        var rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward;
    }

    void Update()
    {
    }
    
}
