using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool IsGamePaused = false;
    public GameObject PauseScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseScreen.SetActive(true);
            IsGamePaused = true;
            Time.timeScale = 0.0f;
        }

        if (IsGamePaused == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PauseScreen.SetActive(false);
                IsGamePaused = false;
                Time.timeScale = 1.0f;
            }
        }
    }
}
