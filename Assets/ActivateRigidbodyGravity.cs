using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRigidbodyGravity : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    void OnTriggerExit (Collider collider)
    {
        rb.useGravity = true;
    }
}
