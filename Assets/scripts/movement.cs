using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
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

    private bool isDead;
    [SerializeField] private Camera currentCameraPlayer;
    [SerializeField] private Vector3 spawnPos;
    [SerializeField] private GameObject clone;
    public AudioSource gas;

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
        currentCameraPlayer = GameObject.FindWithTag("SecondCamera").GetComponent<Camera>();
        gas = GameObject.FindWithTag("SFXGas").GetComponent<AudioSource>();
    }

    private void InstanceOnDeath(bool dead, GameObject charParent)
    {
        if (charParent.name == this.gameObject.name)
        {
            isDead = dead;
        }
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            currentCameraPlayer.transform.DOMoveX(0, 1).SetEase(Ease.InOutCubic);
            // GameObject newPlayer = Instantiate(clone, spawnPos, Quaternion.Euler(0,0,0));
            // // newPlayer.transform.position = spawnPos;
            PlayerManager.Instance.RestartPlayer(false, clone, spawnPos);
            Destroy(this.gameObject);
            
        }
        
        if (isDead) return;
        
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
            StartCoroutine(Kentut_Gas());
        }
    }

    private void Kentut()
    {
        if (PlayerManager.Instance.GetKentut() < 15f) return;
        fartParticles.Play();
        rb.AddForce(Vector2.up * jumpforce);
        PlayerManager.Instance.Kentut();
    }
    IEnumerator Kentut_Gas()
    {
        gas.Play();
        yield return new WaitForSeconds(0.05f);
        Kentut();
    }
}
