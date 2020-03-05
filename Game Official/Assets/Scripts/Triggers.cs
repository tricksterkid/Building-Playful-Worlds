using UnityEngine;

public class Triggers : MonoBehaviour
{

    public GameObject DoorToBeOpened;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            DoorToBeOpened.SetActive(false);
        }
    }

}
