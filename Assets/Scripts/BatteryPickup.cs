using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float lightAngle = 30f;
    [SerializeField] float lightIntensity = 30f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            Debug.Log(other.gameObject.name + " picked up " + this.name);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLight(lightAngle, lightIntensity);
            Destroy(gameObject);
        }
    }
}
