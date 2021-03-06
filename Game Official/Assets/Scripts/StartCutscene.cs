﻿using System.Collections;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject CutsceneCam;
    public GameObject SkipScene;
    // add in box to make sure box is always closed, even when cutscene is skipped
    public GameObject Box;
    private Animation closeBox;
    private bool IsCutscenePlaying = false;

    // get animation
    void Start()
    {
        closeBox = Box.GetComponent<Animation>();
    }

    // what happens when player walks into trigger
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        CutsceneCam.SetActive(true);
        SkipScene.SetActive(true);
        Player.SetActive(false);
        IsCutscenePlaying = true;
        StartCoroutine(FinishCut());
        StartCoroutine(DeleteMessage());
    }

    // coroutine that manages cutscene
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(30);
        Player.SetActive(true);
        CutsceneCam.SetActive(false);
        IsCutscenePlaying = false;
    }

    // coroutine that manages the skip cutscene message
    IEnumerator DeleteMessage()
    {
        yield return new WaitForSeconds(5);
        SkipScene.SetActive(false);
    }

    // what happens when the player presses e when the cutscene is playing
    void Update()
    {
        if (IsCutscenePlaying == true && Input.GetKeyDown(KeyCode.E))
        {
            Player.SetActive(true);
            closeBox.Play("Chest Closes");
            CutsceneCam.SetActive(false);
            SkipScene.SetActive(false);
            IsCutscenePlaying = false;
        }
    }
}
