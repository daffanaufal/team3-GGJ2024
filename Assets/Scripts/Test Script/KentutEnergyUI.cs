using System;
using UnityEngine;
using UnityEngine.UI;

namespace Test_Script
{
    public class KentutEnergyUI : MonoBehaviour
    {
        [SerializeField] private Slider kentutSlider;

        private void Start()
        {
            // PlayerManager.Instance.ONKentut += InstanceOnKentut;
        }

        private void InstanceOnKentut()
        {
            
        }

        private void Update()
        {
            kentutSlider.value = PlayerManager.Instance.GetKentut();
        }
    }
}