using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace CodeDemo.CounterMid
{
    public class EventRaiser : MonoBehaviour
    {
        [SerializeField] XRGrabInteractable grabInteractable;
        [SerializeField] Counter counter;

        private void Awake()
        {
            grabInteractable.hoverEntered.AddListener(TriggerOnHoverEntered);
        }

        void TriggerOnHoverEntered(HoverEnterEventArgs hoverEnterEventArgs)
        {
            counter.AddAmmount(1);
        }
    }
}
