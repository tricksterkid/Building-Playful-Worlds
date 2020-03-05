using UnityEngine;

public class OfficialOpenDoor : MonoBehaviour
{

    public GameObject successMessage;
    public GameObject failMessage;
    public GetKey key;
    //private Animation openDoor;

    private void Start()
    {
        //openDoor = gameObject.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player") && key.hasKey == true)
        {
            //openDoor.Play("OfficialOpenDoor");
            Destroy(gameObject);
            successMessage.SetActive(true);
            Destroy(successMessage, 1.5f);

        } else
        {
            failMessage.SetActive(true);
            Destroy(failMessage, 1.5f);
        }
    }

}
