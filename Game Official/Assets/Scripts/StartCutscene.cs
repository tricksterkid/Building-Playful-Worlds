using System.Collections;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject CutsceneCam;
    public GameObject SkipScene;
    // add in box to make sure box is always closed, even when cutscene is skipped
    public GameObject Box;
    private Animation closeBox;

    private void Start()
    {
        closeBox = Box.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        CutsceneCam.SetActive(true);
        SkipScene.SetActive(true);
        Player.SetActive(false);
        StartCoroutine(FinishCut());
        StartCoroutine(DeleteMessage());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(30);
        Player.SetActive(true);
        CutsceneCam.SetActive(false);
    }

    IEnumerator DeleteMessage()
    {
        yield return new WaitForSeconds(5);
        SkipScene.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player.SetActive(true);
            closeBox.Play("Chest Closes");
            CutsceneCam.SetActive(false);
            SkipScene.SetActive(false);
        }
    }
}
