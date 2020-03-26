using UnityEngine;
using UnityEngine.UI;

public class DifficultySettings : MonoBehaviour
{
    bool HasBeenClicked = false;
    public GameObject DifficultyPanel;
    public Button EasyMode;
    public Button NormalMode;

    void Start()
    {
        Cursor.visible = true;

        Button btn1 = EasyMode.GetComponent<Button>();
        btn1.onClick.AddListener(Click1);

        Button btn2 = NormalMode.GetComponent<Button>();
        btn2.onClick.AddListener(Click2);
    }

    void Click1()
    {
        HasBeenClicked = true;
    }

    void Click2()
    {
        HasBeenClicked = true;
    }

    void Update()
    {
        Time.timeScale = 0.0f;

        if (HasBeenClicked == true && Input.GetKeyDown(KeyCode.E))
        {
            DifficultyPanel.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1.0f;
        }
    }
}
