using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        Debug.Log(name + " has been reduced to " + hitPoints + " health");
        if (hitPoints <= 0)
            Destroy(gameObject);
    }
}
