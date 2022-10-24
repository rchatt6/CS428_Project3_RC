using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesSpawn : MonoBehaviour
{
    public AudioClip audio;
    public GameObject item;
    public GameObject portal;
    int count = 0;


    public void OnTriggerEnter(Collider collider)
    {
        if(count < 5){
            portal.SetActive(true);
            AudioSource.PlayClipAtPoint(audio, transform.position);
            //Instantiate(item, spawnlocation.transform.position, Quaternion.identity);
            Instantiate(item, new Vector3(-3f, -.2f, 3.75f), Quaternion.Euler(new Vector3(90f, 0f, 0f)));
            Debug.Log(item.transform.localPosition);
            Debug.Log(item.transform.localRotation);
            count++;

        }
        else{
            portal.GetComponent<Animator>().Play("Base Layer.Portal Disappearing");

        }
    }
            

}
