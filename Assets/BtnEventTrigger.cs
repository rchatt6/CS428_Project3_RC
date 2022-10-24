using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BtnEventTrigger : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider collider)
    {
        myAnimationController.SetBool("btnTrigger", true);
    }

        private void OnTriggerExit(Collider collider)
    {
        myAnimationController.SetBool("btnTrigger", false);
    }
        
    
}
