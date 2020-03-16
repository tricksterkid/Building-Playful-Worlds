using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
