using System;
using UnityEngine;

namespace Test_Script
{
    public class JointBreaks : MonoBehaviour
    {
        private ParticleSystem _blood;

        private void Start()
        {
            _blood = GetComponentInChildren<ParticleSystem>();
        }

        private void OnJointBreak2D(Joint2D brokenJoint)
        {
            Debug.Log("Joint where: " + this.gameObject.name + " breaks");
            if (_blood != null)
            {
                _blood.Play();
            }
        }
    }
}