using UnityEngine;
using UnityEngine.SceneManagement;

public class PressEnterToContinue : MonoBehaviour
{

    void Update()
    {

        if(Input.GetKeyDown (KeyCode.Return))
        {
            SceneManager.LoadScene("Level01");
        }

    }

}
