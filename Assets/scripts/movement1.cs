using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Test_Script;
using UnityEngine;

public class movement1 : MonoBehaviour
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
    private bool isDead;
    [SerializeField] private Camera currentCameraPlayer;
    [SerializeField] private Vector3 spawnPos;
    [SerializeField] private GameObject clone;

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
        PlayerManager.Instance.ONDeath += InstanceOnDeath;
        currentCameraPlayer = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

    }

    private void InstanceOnDeath(bool dead, GameObject charParent)
    {
        if (charParent == this.gameObject)
        {
            isDead = dead;
        }
        
    }
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Instantiate(clone, spawnPos, Quaternion.Euler(0,0,0));
            currentCameraPlayer.transform.DOMoveX(0, 1).SetEase(Ease.InOutCubic);
            PlayerManager.Instance.RestartPlayer(true, clone, spawnPos);
            Destroy(this.gameObject);
        }
        
        if (isDead) return;

        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector2.right * playerspeed);
        }
        else if (Input.GetKey("a"))
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
        fartParticles.Play();
        rb.AddForce(Vector2.up * jumpforce);
        PlayerManager.Instance.Kentut();
    }


}
