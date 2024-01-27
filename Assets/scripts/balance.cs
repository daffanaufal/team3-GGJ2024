using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balance : MonoBehaviour
{
    public float targetrotation;
    public float force;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetrotation, force * Time.fixedDeltaTime));
    }

}
