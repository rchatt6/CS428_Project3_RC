using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnTriggerEnter : MonoBehaviour
{
    public AudioClip[] audio = new AudioClip[4];
    public GameObject[] lights = new GameObject[4];
    int count = 0;


    void OnTriggerEnter()
    {
        int sound = Random.Range(0, audio.Length);
        lights[0].SetActive(false);
        lights[1].SetActive(false);
        lights[2].SetActive(false);
        lights[3].SetActive(false);

        

        //AudioSource.PlayClipAtPoint(audio[sound], transform.position);
        if(!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().PlayOneShot(audio[sound]);
            lights[sound].SetActive(true);
        }
        
    }
}
