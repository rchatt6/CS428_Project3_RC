using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionWithPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().enabled = true;
    }
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    /*void OnCollisionEnter(Collision collision)
    {
        GetComponent<Collider>().enabled = false;
        if (collision.collider.tag == "Player")
        {
            GetComponent<Collider>().enabled = false;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        GetComponent<Collider>().enabled = true;
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<Collider>().enabled = true;
        }
    }*/

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            //GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
           //GetComponent<Collider>().enabled = true;
           GetComponent<Renderer>().enabled = true;
        }
    }
}
