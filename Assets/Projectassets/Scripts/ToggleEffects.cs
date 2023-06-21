using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class ToggleEffects : MonoBehaviour
{
    [SerializeField] RenderObjects renderObjectsFeature;
    [SerializeField] InputActionReference toggleActionRef;
    public GameObject sonarObject;
    bool SonarIsOn;
    [SerializeField] float timeToEnd;

    //private bool triggered;
    //public GameObject sonarObject;
    //bool SonarIsOn = true;

    void Awake()
    {
        toggleActionRef.action.performed += Action_performed;
        DeactivateAll();
    }

    void OnDestroy()
    {
        toggleActionRef.action.performed -= Action_performed;
    }

    /*
    private void Update()
    {
        sonarObject = GameObject.Find ("Sonar");

        float val = toggleActionRef.action.ReadValue<float>();

        if (val > 0 && !triggered)
        {
            Debug.Log("executed");
            Toggle();
            triggered = true;
        }
        else
        {
            triggered = false;
        }

    }
    */

    void Action_performed(InputAction.CallbackContext context)
    {
        Toggle();
    }

    [ContextMenu("ToggleEffect")]
    void Toggle()
    {
        renderObjectsFeature.SetActive(!renderObjectsFeature.isActive);
        if (SonarIsOn == true)
        {
            SonarIsOn = false;
            sonarObject.SetActive(false);
        }
        else
        {
            SonarIsOn = true;
            sonarObject.SetActive(true);
            Invoke(nameof(DeactivateAll), timeToEnd);
        }
    }
    void DeactivateAll()
    {
        SonarIsOn = false;
        renderObjectsFeature.SetActive(false);
        sonarObject.SetActive(false);
    }
    
}