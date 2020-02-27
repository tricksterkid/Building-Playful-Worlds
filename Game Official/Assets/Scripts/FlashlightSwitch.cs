using UnityEngine;

public class FlashlightSwitch : MonoBehaviour
{

    public Light Flashlight;

    void Start()
    {
        Flashlight.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Flashlight.enabled == false)
        {
            Flashlight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && Flashlight.enabled == true)
        {
            Flashlight.enabled = false;
        }
    }

}
