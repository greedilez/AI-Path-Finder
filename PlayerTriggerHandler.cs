using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            FindObjectOfType<Canvas>().enabled = true;
        }
    }
}
