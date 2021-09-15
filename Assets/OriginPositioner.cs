using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginPositioner : MonoBehaviour
{

    public GameObject Origin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Origin.transform.position;
    }
}
