using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class YoneticiController : MonoBehaviour
{
    public GameObject apple;
    public Button pauseButton;
    public Sprite imgPause;
    public Sprite imgPlay;
    public GameObject panel;
    private TextMeshProUGUI _textMeshProUGUI;

    bool isPaused = false;

    void Start()
    {
        InvokeRepeating("AddApple", 0.0f, 1.0f);
        _textMeshProUGUI = panel.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void PauseBtnClick()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0.0f;
            pauseButton.GetComponent<Image>().sprite = imgPlay;

            _textMeshProUGUI.text = "Pause";
            panel.SetActive(true);


        }
        else
        {
            Time.timeScale = 1.0f;
            pauseButton.GetComponent<Image>().sprite = imgPause;

            _textMeshProUGUI.text = "Game Over";
            panel.SetActive(false);

        }
    }


    public void RestartBtnClick()
    {
        SceneManager.LoadScene("Scenes/AppleGame");
        Time.timeScale = 1.0f;
    }


    public void ExitBtnClick()
    {
        Application.Quit();
    }

   

    void AddApple()
    {
        float rand = Random.Range(-4.0f, 12.0f);
        Instantiate(apple, new Vector3(rand, 9.31f, -6.65f), Quaternion.identity);
    }
}
