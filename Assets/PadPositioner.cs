using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadPositioner : MonoBehaviour
{
    public GameObject PadOrigin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(
            PadOrigin.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z);
    }
}
