using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleSonar : MonoBehaviour
{
    [SerializeField] InputActionReference toggleActionRef;
    public GameObject sonarObject;
    bool SonarIsOn = true;

    void Awake()
    {
        toggleActionRef.action.performed += Toggle;
        sonarObject.SetActive(false);
    }

    void OnDestroy()
    {
        toggleActionRef.action.performed -= Toggle;
    }
    // Update is called once per frame

    private void Toggle(InputAction.CallbackContext context)
    {
        if (SonarIsOn == true)
        {
            SonarIsOn = false;
            sonarObject.SetActive(true);
        }
        else
        {
            SonarIsOn = true;
            sonarObject.SetActive(false);
        }
    }
}
