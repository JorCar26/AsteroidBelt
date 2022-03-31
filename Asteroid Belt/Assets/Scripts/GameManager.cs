using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text playerScore;
    public Text gameOver;
    public GameObject restartButton;
    public GameObject mainMenuButton;
    public GameObject quitButton;
    PlayerBaseStats pBaseStats;
    void Start()
    {
        pBaseStats = GetComponent<PlayerBaseStats>();
        playerScore.text = "Score: " + 0;
        gameOver.text = "";
    }
    public void updateScore(float score)
    {
        playerScore.text = "Score: " + score.ToString();
    }
    public void WinScreen()
    {
        gameOver.text = "YOU WIN!!!";
        restartButton.SetActive(true);
        mainMenuButton.SetActive(true);
        quitButton.SetActive(true);
    }
    public void LoseScreen()
    {
        gameOver.text = "YOU LOSE!";
        restartButton.SetActive(true);
        mainMenuButton.SetActive(true);
        quitButton.SetActive(true);
    }
    public void KillBoxScreen()
    {
        gameOver.text = "Off Screen is Scary!";
        restartButton.SetActive(true);
        mainMenuButton.SetActive(true);
        quitButton.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
