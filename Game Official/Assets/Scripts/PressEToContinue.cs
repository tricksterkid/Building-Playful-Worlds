using UnityEngine;
using UnityEngine.SceneManagement;

public class PressEToContinue : MonoBehaviour
{

    void Update()
    {

        if(Input.GetKeyDown (KeyCode.E))
        {
            SceneManager.LoadScene("Level01");
        }

    }

}
