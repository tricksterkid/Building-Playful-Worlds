using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource Thunder;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CutsceneCam"))
        {
            Thunder.Play();
        }
    }
}
