using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollumnPressed : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;

    public GameObject Sunlight1;
    public GameObject Sunlight2;

    public GameObject Candle1;
    public GameObject Candle2;
    public GameObject Candle3;
    public GameObject Candle4;

    public GameObject RavenclawStatue;
    public GameObject SlytherinStatue;
    public GameObject HufflepuffStatue;
    public GameObject GriffindorStatue;

    public GameObject DayItems;
    public GameObject NightItems;

    public AudioSource audioSource;
    public AudioClip audioClipGood;
    public AudioClip audioClipBad;
    bool isOn = true;



    private void OnTriggerEnter(Collider collider)
    {
        if (isOn == false)
        {
            //Turn On
            Light1.GetComponent<Light>().intensity = 3;
            Light2.GetComponent<Light>().intensity = 0;
            Light3.GetComponent<Light>().intensity = 3;
            Light4.GetComponent<Light>().intensity = 0;

            //LightBulb Appears
            Candle1.SetActive(true);
            Candle2.SetActive(false);
            Candle3.SetActive(true);
            Candle4.SetActive(false);

            Sunlight1.SetActive(true);
            Sunlight2.SetActive(true);

            RavenclawStatue.SetActive(true);
            SlytherinStatue.SetActive(false);
            HufflepuffStatue.SetActive(true);
            GriffindorStatue.SetActive(false);

            DayItems.SetActive(true);
            NightItems.SetActive(false);

            audioSource.Stop();
            audioSource.PlayOneShot(audioClipGood);
            isOn = true;
        }
        else
        {
            //Turn off
            Light1.GetComponent<Light>().intensity = 0;
            Light2.GetComponent<Light>().intensity = 3;
            Light3.GetComponent<Light>().intensity = 0;
            Light4.GetComponent<Light>().intensity = 3;

            //LightBulb disappears
            Candle1.SetActive(false);
            Candle2.SetActive(true);
            Candle3.SetActive(false);
            Candle4.SetActive(true);

            Sunlight1.SetActive(false);
            Sunlight2.SetActive(false);

            RavenclawStatue.SetActive(false);
            SlytherinStatue.SetActive(true);
            HufflepuffStatue.SetActive(false);
            GriffindorStatue.SetActive(true);

            DayItems.SetActive(false);
            NightItems.SetActive(true);

            audioSource.Stop();
            audioSource.PlayOneShot(audioClipBad);
            isOn = false;
        }

    }
}
