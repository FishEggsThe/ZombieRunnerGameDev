using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] StarterAssets.FirstPersonController fpsController;

    float zoomedOutFOV = 40f;
    float zoomedInFOV = 20f;
    float ZoomedOutSensitivity = 2f;
    float ZoomedInSensitivity = 1f;
    bool zoomedInToggle = false;

    private void SetZoom(bool zoom)
    {
        zoomedInToggle = zoom;
        fpsCamera.m_Lens.FieldOfView = zoomedInToggle ? zoomedInFOV : zoomedOutFOV;
        fpsController.RotationSpeed = zoomedInToggle ? ZoomedInSensitivity : ZoomedOutSensitivity;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2")) {
            SetZoom(!zoomedInToggle);
        }
    }

    private void OnDisable()
    {
        SetZoom(false);
    }
}
