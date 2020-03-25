using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    public GameObject Particles;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CutsceneCam"))
        {
            Particles.SetActive(true);
        }
    }
}
