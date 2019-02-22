using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Transition")
        {
            other.GetComponent<TriFlipper>().turn = true;
        } 
    }
}
