﻿using UnityEngine;

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
        }
    }
}
