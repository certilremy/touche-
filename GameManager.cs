using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public string nextScenel;
    void Start()
    {
        scoreText.text = "0";
    }

    void Update()
    {
        if (score == 20)
        {
            LoadScene(nextScenel);
        }
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
