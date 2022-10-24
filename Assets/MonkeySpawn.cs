using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySpawn : MonoBehaviour
{
    public AudioClip audio;
    public GameObject item;
    public GameObject portal;

    int count = 0;

    private void OnTriggerEnter(Collider collider)
    {
        if(count < 5){
            portal.SetActive(true);
            AudioSource.PlayClipAtPoint(audio, transform.position);
            //Instantiate(item, spawnlocation.transform.position, Quaternion.identity);
            Instantiate(item, new Vector3(-3f, 1f, 4f), Quaternion.Euler(new Vector3(0f, 90f, 0f)));
            
            Debug.Log(item.transform.localPosition);
            Debug.Log(item.transform.localRotation);
            count++;
        }

        else{
            portal.GetComponent<Animator>().Play("Base Layer.Portal Disappearing");

        }


    }
}
