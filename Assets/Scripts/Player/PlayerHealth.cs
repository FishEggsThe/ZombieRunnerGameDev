using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    float health = 100f;

    public void TakeDamagePlayer(float damage)
    {
        health -= damage;
        Debug.Log(name + " has been reduced to " + health + " health");
        if (health <= 0) {
            Debug.Log("Fucking died");
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
