using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CodeDemo.CounterMid
{
    public class NumberDisplay : MonoBehaviour
    {
        [SerializeField] TMP_Text textComp;
        [SerializeField] Counter counter;

        private void OnEnable()
        {
            counter.OnNewAmmount += Counter_OnNewAmmount;
        }

        private void OnDisable()
        {
            counter.OnNewAmmount -= Counter_OnNewAmmount;
        }

        public void DisplayText(string text)
        {
            textComp.text = text;
        }

        void Counter_OnNewAmmount(int ammount)
        {
            textComp.text = ammount.ToString();
        }
    }
}