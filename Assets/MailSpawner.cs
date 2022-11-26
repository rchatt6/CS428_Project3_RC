using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailSpawner : MonoBehaviour
{
    //public GameObject item;
    //public AudioClip audio;
    public GameObject item; //what you want to spawn
    //public GameObject spawnlocation;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter(GetComponent<Collider>());
    }
*/
    private void OnTriggerEnter(Collider collider)
    {
        //GameObject e = Instantiate(item) as GameObject;
        //AudioSource.PlayClipAtPoint(audio, transform.position);
        //Instantiate(item, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation);

        Debug.Log("Hi");
        Instantiate(item, new Vector3(-7.398f, 13.474f, 7.869f), Quaternion.Euler(new Vector3(0f, -270f, 0f)));
        

        //GameObject a = Instantiate(item, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation) as GameObject;
        //a.GetComponent<MeshRenderer>().enabled = true;
    }
}
