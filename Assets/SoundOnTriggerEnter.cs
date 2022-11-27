using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnTriggerEnter : MonoBehaviour
{
    public AudioClip[] audio = new AudioClip[4];
    public GameObject[] lights = new GameObject[4];


    void OnTriggerEnter()
    {
        int sound = Random.Range(0, audio.Length);


        for(int i = 0; i < 4;i++ ){
            Debug.Log(lights[i].activeInHierarchy);
                    Debug.Log(lights[0].name);


            if(lights[i].activeInHierarchy){
                lights[i].SetActive(false);
            }
        }
        //AudioSource.PlayClipAtPoint(audio[sound], transform.position);
        if(!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().PlayOneShot(audio[sound]);
            lights[sound].SetActive(true);
        }
        
    }
}
