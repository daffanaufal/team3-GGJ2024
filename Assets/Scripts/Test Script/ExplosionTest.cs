using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTest : MonoBehaviour
{
    private Collider2D[] inExplosionRadius = null;

    [SerializeField] private float explosionForceMulti = 5f;
    [SerializeField] private float explosionRadius = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Explode();
        Destroy(this.gameObject);
    }


    private void Explode()
    {
        inExplosionRadius = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        foreach (Collider2D objectCollider in inExplosionRadius)
        {
            Rigidbody2D rbObject = objectCollider.GetComponent<Rigidbody2D>();

            if (rbObject == null) return;
            Vector2 distanceVector = objectCollider.transform.position - transform.position;
            if (distanceVector.magnitude > 0)
            {
                float explosionForce = explosionForceMulti / distanceVector.magnitude;
                rbObject.AddForce(distanceVector.normalized * explosionForce);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}