using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackCollision : MonoBehaviour
{
    public LayerMask playerLayer;
    public float radius;
    private bool collided;

    public Transform hitPoint;
    public float damageCount;

    private Transform player;
    private PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        Collider[] hits = Physics.OverlapSphere(hitPoint.position,radius,playerLayer);
        foreach(Collider c in hits)
        {
            if (c.isTrigger)
            {
                continue;
            }
            collided = true;
            if (collided)
            {
                playerHealth.TakeDamage(damageCount);
            }
        }
    }
}
