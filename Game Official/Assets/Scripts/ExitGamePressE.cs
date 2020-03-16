using UnityEngine;

public class ExitGamePressE : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Quit Game");
            Application.Quit();
        }
    }
}
