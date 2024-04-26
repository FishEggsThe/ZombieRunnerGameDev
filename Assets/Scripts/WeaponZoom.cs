using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    RigidFirstPersonController fpsController;

    float zoomedOutFOV = 40f;
    float zoomedInFOV = 20f;
    float ZoomedOutSensitivity = 2f;
    float ZoomedInSensitivity = 1f;
    bool zoomedInToggle = false;


    private void Start()
    {
        fpsController = GetComponent<RigidFirstPersonController>();
    }

    public void Zoom(bool zoomedIn)
    {
        fpsCamera.m_Lens.FieldOfView = zoomedInToggle ? zoomedInFOV : zoomedOutFOV;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2")) {
            zoomedInToggle = !zoomedInToggle;
        }
    }
}
