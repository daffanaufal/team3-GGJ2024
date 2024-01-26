using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
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
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (horizontalInput > 0)
        {
            rb.AddForce(Vector2.right * playerspeed);
        }
        else if (horizontalInput < 0)
        {
            rb.AddForce(Vector2.left * playerspeed);
        }

        isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, ground);

        if (isOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpforce);
        }
    }



}
