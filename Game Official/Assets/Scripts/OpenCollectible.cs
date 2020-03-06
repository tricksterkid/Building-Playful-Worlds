using UnityEngine;

public class OpenCollectible : MonoBehaviour
{

    public GameObject Panel;
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Panel.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
    
}
