using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSystem : MonoBehaviour
{
    float lightDecay = 0.1f;
    float angleDecay = 0.1f;
    float timeToDecay = 1f;
    bool lightBool = true, angleBool = true;

    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        StartCoroutine(DecreaseLightAngle());
        StartCoroutine(DecreaseLightIntensity());
    }

    public void RestoreLight(float restoreAngle, float restoreLight)
    {
        myLight.spotAngle += restoreAngle;
        myLight.intensity += restoreLight;
    }

    IEnumerator DecreaseLightAngle()
    {
        if(angleBool){
            angleBool = false;
            yield return new WaitForSeconds(timeToDecay);
            myLight.spotAngle -= angleDecay;
            angleBool = true;
        }
    }

    IEnumerator DecreaseLightIntensity()
    {
        if(lightBool){
            lightBool = false;
            yield return new WaitForSeconds(timeToDecay);
            myLight.intensity -= lightDecay;
            lightBool = true;
        }
    }
}
