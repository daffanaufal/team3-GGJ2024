using System;
using UnityEngine;

namespace Test_Script
{
    public class JointBreaks : MonoBehaviour
    {
        private ParticleSystem blood;
        private balance balance;

        private void Start()
        {
            blood = GetComponentInChildren<ParticleSystem>();
            balance = GetComponent<balance>();
        }

        private void OnJointBreak2D(Joint2D brokenJoint)
        {
            Debug.Log("Joint where: " + this.gameObject.name + " breaks");
            if (blood != null)
            {
                if (balance != null) balance.enabled = false;
                blood.Play();
            }
        }
    }
}