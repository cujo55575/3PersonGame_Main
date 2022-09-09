using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStartMove : MonoBehaviour
{
    private SphereCollider col;
    private BossAI bossAI;

    private void Awake()
    {
        col = GetComponent<SphereCollider>();
        bossAI = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossAI>();
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            bossAI.enabled = true;
            col.enabled = false;
        }
    }
}
