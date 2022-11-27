using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandSpawner : MonoBehaviour
{
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

        //Debug.Log("Hi");
        Instantiate(item, new Vector3(-27.5754f, 0.8096f, -5.9128f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        //yield WaitForSeconds(5);


        //GameObject a = Instantiate(item, spawnlocation.GetComponent<Transform>().position, spawnlocation.GetComponent<Transform>().rotation) as GameObject;
        //a.GetComponent<MeshRenderer>().enabled = true;
    }
}
