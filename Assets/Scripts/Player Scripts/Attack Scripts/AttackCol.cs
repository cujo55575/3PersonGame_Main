using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCol : MonoBehaviour
{
    public LayerMask enemyLayer;
    public float radius;
    public GameObject attackEffect;

    public Transform hitPoint;
    public float damageCount;

    private EnemyHealth enemyHealth;
    private bool collided;

    private void Update()
    {
        Collider[] hits = Physics.OverlapSphere(hitPoint.position, radius, enemyLayer);
        foreach(Collider c in hits)
        {
            if (c.isTrigger)
            {
                continue;
            }
            enemyHealth = c.gameObject.GetComponent<EnemyHealth>();
            collided = true;
            if (collided)
            {
                Instantiate(attackEffect, hitPoint.position, hitPoint.rotation);
                enemyHealth.EnemyTakeDamage(damageCount);
            }
        }
    }
}
