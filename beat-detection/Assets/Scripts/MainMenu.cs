using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static int lastScene = 0;

    public void LastLoadedScene()
    {
        lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(lastScene);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("CoreGameScene");
    }

    public void QuitButton()
    {
        Debug.Log("Pressed Quit");
        Application.Quit();
    }

}
