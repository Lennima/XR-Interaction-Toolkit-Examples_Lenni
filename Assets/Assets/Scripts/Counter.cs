using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CodeDemo.CounterMid
{
    public class Counter : MonoBehaviour
    {
        //[SerializeField] NumberDisplay numberDisplay;
        public Action<int> OnNewAmmount;
        int counter;


        public void AddAmmount(int ammont)
        {
            //Debug.Log($"Number was {counter}");
            counter += ammont;
            //Debug.Log($"New number is {ammont}");

            //numberDisplay.DisplayText(counter.ToString());
            OnNewAmmount?.Invoke(counter);
        }
    }
}