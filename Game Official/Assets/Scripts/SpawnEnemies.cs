using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject Enemies;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Enemies.SetActive(true);
        }
    }
}
