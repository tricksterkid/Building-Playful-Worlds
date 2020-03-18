using UnityEngine;

public class OpenCollectible : MonoBehaviour
{
    bool WithinTriggerRange = false;
    bool IsPanelActive = false;
    public GameObject CollectiblePanel;
    public GameObject TutorialMessage;
    public GameObject DoorToBeOpened;
    public GameObject OpenedDoor;
    public GameObject Collectible;

    // what happens when the player collides with the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TutorialMessage.SetActive(true);
            WithinTriggerRange = true;
        }
    }

    // what happens when the player leaves the trigger
    void OnTriggerExit(Collider other)
    {
        TutorialMessage.SetActive(false);
        WithinTriggerRange = false;
    }

    void Update()
    {
        // if the player is in the trigger they can activate the collectible
        if (WithinTriggerRange == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                CollectiblePanel.SetActive(true);
                TutorialMessage.SetActive(false);
                IsPanelActive = true;
                Time.timeScale = 0.0f;
            }
        }

        // if the collectible is active, the player can deactivate it and the trigger is removed
        if (IsPanelActive == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                OpenedDoor.SetActive(true);
                DoorToBeOpened.SetActive(false);
                CollectiblePanel.SetActive(false);
                TutorialMessage.SetActive(false);
                Collectible.SetActive(false);
                IsPanelActive = false;
                gameObject.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }
    }
}
