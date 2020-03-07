using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}

//public void ButtonSettings()
//{
//    SceneManager.LoadScene("Settings");
//}

//public void SettingsExit()
//{
//    SceneManager.LoadScene("Menu");
//}

//private void Update()
//{
//    if (Input.GetKeyDown(KeyCode.Escape))
//    {
//        SceneManager.LoadScene("Menu");
//    }
//}