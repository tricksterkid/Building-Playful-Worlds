using System.Collections;
using UnityEngine;

public class OpenKeyBox : MonoBehaviour
{
    private Animation openBox;

    void Start()
    {
        openBox = gameObject.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openBox.Play("Chest Opens");
            StartCoroutine(StopAnimation());
        }
    }

    IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(1);
        openBox.enabled = !openBox.enabled;
    }
}
