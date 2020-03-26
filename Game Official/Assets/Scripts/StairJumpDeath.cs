using UnityEngine;
using UnityEngine.SceneManagement;

public class StairJumpDeath : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("StairsDeath");
        }
    }
}
