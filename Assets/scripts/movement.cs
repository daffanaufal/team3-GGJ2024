using System.Collections;
using System.Collections.Generic;
using Test_Script;
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
    public ParticleSystem fartParticles;

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

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * playerspeed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * playerspeed);
        }

        isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, ground);

        if (isOnGround && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Kentut();
        }
    }

    private void Kentut()
    {
        if (PlayerManager.Instance.GetKentut() < 15f) return;
        fartParticles.Play();
        rb.AddForce(Vector2.up * jumpforce);
        PlayerManager.Instance.Kentut();
    }
}
