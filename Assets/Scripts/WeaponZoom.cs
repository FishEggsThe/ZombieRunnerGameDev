using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    float zoomedOutFOV = 60f;
    float zoomedInFOV = 20f;
    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            zoomedInToggle = !zoomedInToggle;
            camera.fieldOfView = (zoomedInToggle ? zoomedInFOV : zoomedOutFOV);
        }
    }
}
