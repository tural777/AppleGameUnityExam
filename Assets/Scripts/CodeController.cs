using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CodeController : MonoBehaviour
{
    public void StartBtnClick()
    {
        SceneManager.LoadScene("Scenes/AppleGame");
    }

    public void ExitBtnClick()
    {
        Application.Quit();
    }
}
