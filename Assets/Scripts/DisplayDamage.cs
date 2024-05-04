using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas impactCanvas;
    float timeToDisplay = 0.8f;

    void Start()
    {
        impactCanvas.enabled = false;
    }

    public void ShowSplatter()
    {
        StartCoroutine(DisplaySplatter());
    }

    IEnumerator DisplaySplatter()
    {
        impactCanvas.enabled = true;
        yield return new WaitForSeconds(timeToDisplay);
        impactCanvas.enabled = false;
    }
}
