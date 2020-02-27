using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private Animation fadeOut;

    void Start()
    {
        fadeOut = gameObject.GetComponent<Animation>();
    }

    public void Begin()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Faded()
    {
        fadeOut.Play("FadeOut");
    }

}
