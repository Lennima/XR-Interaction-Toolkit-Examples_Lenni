using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSonar : MonoBehaviour
{
    public GameObject sonarObject;
    bool SonarIsOn = true;

    // Update is called once per frame
    void Update()
    {
        //sonarObject = GameObject.Find ("Sonar");
        if (Input.GetKeyDown("Space"))
        {
            if (SonarIsOn == true)
            {
                SonarIsOn = false;
                sonarObject.enabled = SonarIsOn;
            }
            else
            {
                SonarIsOn = true;
                sonarObject.enabled = SonarIsOn;
            }
        }
    }
}
