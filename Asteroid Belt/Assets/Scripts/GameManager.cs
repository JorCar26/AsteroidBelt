using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text playerScore;
    public Text gameOver;
    public Text levelText;
    public Text levelAnnouncment;
    public Text level2Announcment;
    public Text level3Announcment;
    public GameObject restartButton;
    public GameObject mainMenuButton;
    public GameObject quitButton;
    public int currentLevel;
    PlayerBaseStats pBaseStats;

    public bool GameRunning;

    EnemySpawner enemySpawner;

    private void Awake()
    {
        GameRunning = true;
    }
    void Start()
    {
        pBaseStats = GetComponent<PlayerBaseStats>();
        enemySpawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<EnemySpawner>();
        playerScore.text = "Score: " + 0;
        gameOver.text = "";
        currentLevel = 1;

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
        GameRunning = false;
    }
    public void LoseScreen()
    {
        gameOver.text = "YOU LOSE!";
        restartButton.SetActive(true);
        mainMenuButton.SetActive(true);
        quitButton.SetActive(true);

        GameRunning = false;
    }
    public void KillBoxScreen()
    {
        gameOver.text = "Off Screen is Scary!";
        restartButton.SetActive(true);
        mainMenuButton.SetActive(true);
        quitButton.SetActive(true);
        GameRunning = false;
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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (currentLevel == 1)
        {
            levelText.text = "Level:" + currentLevel.ToString();
            if (levelAnnouncment != null)
            {
                levelAnnouncment.text = "LEVEL 1";
            }
            
        }
        if (currentLevel == 2)
        {
            levelText.text = "Level:" + currentLevel.ToString();
            
            if (level2Announcment != null)
            {
                level2Announcment.gameObject.SetActive(true);
                level2Announcment.text = "LEVEL 2";
            }

        }
        if (currentLevel == 3)
        {
            levelText.text = "Level:" + currentLevel.ToString();
            if (level3Announcment != null)
            {
                level3Announcment.gameObject.SetActive(true);
                level3Announcment.text = "FINAL LEVEL";
            }
        }
    }
}
