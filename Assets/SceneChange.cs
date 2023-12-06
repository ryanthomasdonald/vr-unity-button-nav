using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   public void LoadSceneOne()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void LoadSceneTwo()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void LoadSceneThree()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
