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
            Debug.Log("Joint where: " + this.gameObject.name + this.transform.parent.gameObject.name +" breaks");
            if (gameObject.name == "kepala")
            {
                PlayerManager.Instance.Death(true, transform.parent.gameObject);
            }
            if (blood != null)
            {
                if (balance != null) balance.enabled = false;
                blood.Play();
            }
        }
    }
}