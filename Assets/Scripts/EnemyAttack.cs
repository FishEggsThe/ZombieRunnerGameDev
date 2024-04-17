using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    float damage = 40f;

    void Start()
    {
        target = FindFirstObjectByType<PlayerHealth>();
    }

    private void OnDamageTaken()
    {
       Debug.Log("Oh you're FUCKIN dead");
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.GetComponent<PlayerHealth>().TakeDamagePlayer(damage);
        Debug.Log("bang bang");
    }
}
