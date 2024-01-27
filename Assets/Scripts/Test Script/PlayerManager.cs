using System;
using UnityEngine;

namespace Test_Script
{
    public class PlayerManager : MonoBehaviour
    {
        
        [SerializeField] private float maxEnergyKentut;
        [SerializeField] private float rateKentut;
        [SerializeField] private float rechargeRateKentut;

        public event Action ONKentut;

        private float _energyKentut = 0;
        
        public new static PlayerManager Instance { get; private set; }
        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            _energyKentut = maxEnergyKentut;
            // ONKentut += Kentut;
            InvokeRepeating("RechargeKentut", 0f, 1f);
        }

        private void Update()
        {
        }

        public void Kentut()
        {
            _energyKentut -= rateKentut;
        }

        public float GetKentut()
        {
            return this._energyKentut;
        }

        private void RechargeKentut()
        {
            _energyKentut += rechargeRateKentut;
            Mathf.Clamp(_energyKentut, 0f, maxEnergyKentut);
        }
    }
}