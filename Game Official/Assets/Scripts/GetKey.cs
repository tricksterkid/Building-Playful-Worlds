using UnityEngine;

public class GetKey : MonoBehaviour
{
    public GameObject message;
    public bool hasKey = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);

            message.SetActive(true);
            Destroy(message, 1.5f);

            hasKey = true;
        }
    }
}
