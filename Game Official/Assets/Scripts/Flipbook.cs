using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flipbook : MonoBehaviour
{
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page6;
    public GameObject Page7;
    public GameObject Page8;
    public GameObject Page9;
    public GameObject Page10;

    void FixedUpdate()
    {
        Page1.SetActive(true);
    }

    IEnumerator FlipThroughPages()
    {
        yield return new WaitForSeconds(3);
        Page2.SetActive(true);
        Page1.SetActive(false);
        yield return new WaitForSeconds(3);
        Page3.SetActive(true);
        Page2.SetActive(false);
        yield return new WaitForSeconds(3);
        Page4.SetActive(true);
        Page3.SetActive(false);
        yield return new WaitForSeconds(3);
        Page5.SetActive(true);
        Page4.SetActive(false);
        yield return new WaitForSeconds(3);
        Page6.SetActive(true);
        Page5.SetActive(false);
        yield return new WaitForSeconds(3);
        Page7.SetActive(true);
        Page6.SetActive(false);
        yield return new WaitForSeconds(3);
        Page8.SetActive(true);
        Page7.SetActive(false);
        yield return new WaitForSeconds(3);
        Page9.SetActive(true);
        Page8.SetActive(false);
        yield return new WaitForSeconds(3);
        Page10.SetActive(true);
        Page9.SetActive(false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Endscreen");
    }

    void Update()
    {
        StartCoroutine(FlipThroughPages());
    }
}
