using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_DamageBoss : MonoBehaviour
{
    public LayerMask layerMask;
    public float radius;
    public GameObject damageEffect;
    public float damageCount;
    private bool collided;

    private BossHealth bossHealth;

    private void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius, layerMask);
        foreach (Collider c in hits)
        {
            if (c.isTrigger)
            {
                continue;
            }
            collided = true;
            bossHealth = c.gameObject.GetComponent<BossHealth>();
            if (collided)
            {
                Instantiate(damageEffect, transform.position, transform.rotation);
                bossHealth.BossTakeDamage(damageCount);
                Destroy(gameObject);
            }
        }
    }
}
