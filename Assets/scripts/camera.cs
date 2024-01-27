using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target; 
    public float FollowSpeed = 2f;
    public float y;
    void Update()
    {
        
            Vector3 newPos = new Vector3(target.position.x, y,-10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        
    }
}


