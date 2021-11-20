using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUiController : MonoBehaviour

{
    // Start is called before the first frame update
    public string sceneName;
    public GameObject helpPanel;

    public void LaunchGame()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RetunrToHome()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ShowHelp()
    {
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        helpPanel.SetActive(false);
    }
}
