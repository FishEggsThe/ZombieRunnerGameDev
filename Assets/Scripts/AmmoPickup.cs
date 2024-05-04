using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] public AmmoType ammoType;
    [SerializeField] int ammoAmount = 30;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            Debug.Log(other.gameObject.name + " picked up " + this.name);
            FindFirstObjectByType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject);
        }
    }
}
