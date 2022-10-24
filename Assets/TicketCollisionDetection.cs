using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketCollisionDetection : MonoBehaviour
{
    public AudioClip audio;
    public GameObject item;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    private void OnTriggerEnter(Collider collider)
    {
        
        AudioSource.PlayClipAtPoint(audio, transform.position);

        Instantiate(item, new Vector3(-1.2f, -.4f, 5.2f), Quaternion.Euler(new Vector3(-90f, 0f, 0f)));

    }
}
