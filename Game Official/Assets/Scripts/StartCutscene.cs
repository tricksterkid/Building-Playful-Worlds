using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject CutsceneCam;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        CutsceneCam.SetActive(true);
        Player.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(30);
        Player.SetActive(true);
        CutsceneCam.SetActive(false);
    }
}
