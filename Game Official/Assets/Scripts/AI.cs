using UnityEngine;
using UnityEngine.SceneManagement;

public class AI : MonoBehaviour
{
    public float Speed;
    public GameObject Player;

    void Update()
    {
        Vector3 localPosition = Player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * Speed, localPosition.y * Time.deltaTime * Speed, localPosition.z * Time.deltaTime * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Fail");
        }
    }

}
