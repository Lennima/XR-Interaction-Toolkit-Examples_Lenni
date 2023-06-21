using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject panel; // Reference to the panel GameObject to be triggered

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Victor"))
        {
            panel.SetActive(true); // Activate the panel when the trigger object is touched
            Time.timeScale = 0f;
        }

    }
}
   
