using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float score;
    public int life;
    public bool gameOver = false;

    private void Update()
    {
        if (life <= 0)
        {
            GameOver();
        }
           
    }

    private void GameOver()
    {
            Time.timeScale = 0;
            gameOver = true;
    }

    public void RestartAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        gameOver = false;
        score = 0;
        life = 5;
    }
}
