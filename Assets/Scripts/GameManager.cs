using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject introCanvas;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void intro()
    {
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
    public void Play()
    {
        introCanvas.SetActive(false);
    }
}
