using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Lightning : MonoBehaviour
{
    public float delay1;
    public float delay2;
    public float minIntensity;
    public float maxIntensity;
    public bool startAtMin;

    // variable to hold a reference to the Light component on this gameObject
    private Light myLight;
    private float timeElapsed;

    private void Awake()
    {
        myLight = GetComponent<Light>();

        // if the GetComponent was successful, the variable will no longer be empty (null)
        if (myLight != null)
        {
            // if startAtMin is true, set intensity to the min to start, otherwise set to max
            myLight.intensity = startAtMin ? minIntensity : maxIntensity;
        }
    }

    private void Update()
    {
        // if we have a reference to the Light component
        if (myLight != null)
        {
            // add the amount of time that has passed since last frame
            timeElapsed += Time.deltaTime;

            // if the amount of time passed is greater than or equal to the delay
            
            if (timeElapsed >= delay1)
            {
                ToggleLight();
                //timeElapsed = 0;
            }

            if (timeElapsed >= delay2)
            {
                ToggleLight();
                timeElapsed = 0;
            }

        }
    }

    public void ToggleLight()
    {
        // if the variable is not empty
        if (myLight != null)
        {
            // if the intensity is currently the minimum, switch to max
            if (myLight.intensity == minIntensity)
            {
                myLight.intensity = maxIntensity;
            }
            // if the intensity is currently the max, switch to min
            else if (myLight.intensity == maxIntensity)
            {
                myLight.intensity = minIntensity;
            }
        }
    }
}