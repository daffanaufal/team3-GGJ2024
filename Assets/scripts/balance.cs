using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balance : MonoBehaviour
{
    public float targetrotation;
    public float force;
    public Rigidbody2D rb;

    public event Action ONJointBreaks;

    private void OnJointBreak2D(Joint2D brokenJoint)
    {
        // Invoke stop movement / Death trigger
        Debug.Log("Player is losing a limb");
        ONJointBreaks?.Invoke();
    }

    // Update is called once per frame
    public void Update()
    {
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetrotation, force * Time.fixedDeltaTime));
    }

}
