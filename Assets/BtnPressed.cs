using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPressed : MonoBehaviour
{
    public GameObject LeftLight;
    public GameObject RightLight;
    public GameObject MyModelLights;
    public GameObject ModelLights;
    public GameObject ModelBulb;
    public GameObject MyModelBulb;
    bool isOn = false;
 
 

    private void OnTriggerEnter(Collider collider)
    {
        if(isOn == false){
            //Turn On
            LeftLight.GetComponent<Light>().intensity = 3;
            RightLight.GetComponent<Light>().intensity = 3;
            MyModelLights.GetComponent<Light>().intensity = 6;
            ModelLights.GetComponent<Light>().intensity = 6;

            //LightBulb Appears
            ModelBulb.SetActive(true);
            MyModelBulb.SetActive(true);
            isOn = true;
            }
        else {
            //Turn off
            LeftLight.GetComponent<Light>().intensity = 0;
            RightLight.GetComponent<Light>().intensity = 0;
            MyModelLights.GetComponent<Light>().intensity = 0;
            ModelLights.GetComponent<Light>().intensity = 0;

            //LightBulb disappears
            ModelBulb.SetActive(false);
            MyModelBulb.SetActive(false);
            isOn = false;
        }

    }
}
