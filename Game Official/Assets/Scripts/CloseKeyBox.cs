using UnityEngine;

public class CloseKeyBox : MonoBehaviour
{
    public GameObject Box;
    private Animation closeBox;

    void Start()
    {
        closeBox = Box.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CutsceneCam"))
        {
            closeBox.Play("Chest Closes");
        }
    }
}
