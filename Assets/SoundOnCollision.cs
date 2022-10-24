using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundOnCollision : MonoBehaviour
{
    public AudioClip[] audio = new AudioClip[4];
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }*/

    void OnCollisionEnter()
    {
        int sound = Random.Range(0, audio.Length);
        //AudioSource.PlayClipAtPoint(audio[sound], transform.position);
        GetComponent<AudioSource>().PlayOneShot(audio[sound]);
    }

}
