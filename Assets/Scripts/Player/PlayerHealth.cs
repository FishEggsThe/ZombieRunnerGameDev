using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    DisplayDamage displayDamage;
    float health = 100f;

    void Start()
    {
        displayDamage = GetComponent<DisplayDamage>();
    }

    public void TakeDamagePlayer(float damage)
    {
        health -= damage;
        displayDamage.ShowSplatter();
        Debug.Log(name + " has been reduced to " + health + " health");
        if (health <= 0) {
            Debug.Log("Fucking died");
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
