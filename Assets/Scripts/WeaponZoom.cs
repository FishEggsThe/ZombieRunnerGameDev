using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    //CinemachineVirtualCamera camera;
    float zoomedOutFOV = 60f;
    float zoomedInFOV = 20f;
    bool zoomedInToggle = false;

    public void Zoom(bool zoomedIn)
    {
        //camera.m_Lens.FieldOfView = zoomedInToggle ? zoomedInFOV : zoomedOutFOV;
    }

    /*private void Update()
    {
        if (Input.GetButtonDown("Fire2")) {
            zoomedInToggle = !zoomedInToggle;
            GetComponent<Camera>().fieldOfView = (zoomedInToggle ? zoomedInFOV : zoomedOutFOV);
        }
    }*/
}
