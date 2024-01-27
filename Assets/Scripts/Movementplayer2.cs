using System.Collections;
using System.Collections.Generic;
using Test_Script;
using UnityEngine;

public class Movementplayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float jumpforce;
    public float playerspeed;
    public Vector2 jumpheitght;
    private bool isOnGround;
    public float positionRadius;
    public LayerMask ground;
    public Transform playerPos;

    private Joint2D[] listJoint = null;
    
    void Start()
    {
        Collider2D[] colliders = transform.GetComponentsInChildren < Collider2D>();
        for(int i =0; i<colliders.Length; i++)
        {
            for(int k = i + 1; k <colliders.Length; k++)
            {
                Physics2D.IgnoreCollision(colliders[i], colliders[k]);
            }
        }
        
        
    }

    // Update is called once per frame
    public void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * playerspeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * playerspeed);
        }

        isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, ground);

        if (isOnGround && Input.GetKeyDown(KeyCode.W))
        {
            Kentut();
        }
    }

    private void Kentut()
    {
        if (PlayerManager.Instance.GetKentut() < 15f) return;

        rb.AddForce(Vector2.up * jumpforce);
        PlayerManager.Instance.Kentut();
    }
}
