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
            PlayerManager.Instance.ONKentutInit += InstanceOnKentut;
        }

        private void InstanceOnKentut(float maxEnergy, float rateDrop)
        {
            kentutSlider.maxValue = maxEnergy;
            
        }

        private void Update()
        {
            kentutSlider.value = PlayerManager.Instance.GetKentut();
        }
    }
}