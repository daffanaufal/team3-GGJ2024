using System;
using UnityEngine;

namespace Test_Script
{
    public class PlayerManager : MonoBehaviour
    {
        
        [SerializeField] private float maxEnergyKentut;
        [SerializeField] private float rateKentut;
        [SerializeField] private float rechargeRateKentut;
        [SerializeField] private GameObject clonePerempuan;
        [SerializeField] private GameObject cloneLakilaki;

        public event Action<float, float> ONKentutInit;

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
            InvokeRepeating("RechargeKentut", 0f, .2f);
            ONKentutInit?.Invoke(maxEnergyKentut, rateKentut);
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
            if (_energyKentut >= maxEnergyKentut) return;
            
            _energyKentut += rechargeRateKentut;
        }

        public event Action<bool, GameObject> ONDeath;

        public void Death(bool isDeed, GameObject characterParent)
        {
            ONDeath?.Invoke(isDeed, characterParent);
        }
        
        public event Action<bool, GameObject, Vector3> ONRestartPlayer;
        public void RestartPlayer(bool isCewek, GameObject playerPrefabs, Vector3 spawnPos)
        {
            ONRestartPlayer?.Invoke(isCewek, playerPrefabs, spawnPos);
            if (isCewek)
            {
                Instantiate(clonePerempuan, spawnPos, Quaternion.Euler(0,0,0));
            }
            else
            {
                Instantiate(cloneLakilaki, spawnPos, Quaternion.Euler(0,0,0));
            }
            // GameObject newPlayer = Instantiate(playerPrefabs, spawnPos, Quaternion.Euler(0,0,0));

        }

    }
}