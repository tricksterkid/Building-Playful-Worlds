using UnityEngine;
using UnityEngine.SceneManagement;

public class OfficialOpenDoor : MonoBehaviour
{
    public GameObject failMessage;
    public GetKey key;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && key.hasKey == true)
        {
            SceneManager.LoadScene("EndingScene");

        } else
        {
            failMessage.SetActive(true);
            Destroy(failMessage, 1.5f);
        }
    }
}
