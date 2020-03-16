using UnityEngine;

public class Triggers : MonoBehaviour
{

    public GameObject DoorToBeOpened;
    public GameObject OpenedDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            OpenedDoor.SetActive(true);
            DoorToBeOpened.SetActive(false);
        }
    }

}
