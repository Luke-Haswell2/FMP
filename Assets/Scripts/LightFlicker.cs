using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light theLight;
    
    float interval = 1;
    float timer;
    public float minValue = 1f;
    public float maxValue = 3f;

    void Awake()
    {
        theLight = GetComponent<Light>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            theLight.enabled = !theLight.enabled;
            interval = Random.Range(minValue, maxValue);
            timer = 0f;
        }
    }
}
