using UnityEngine.UI;
using UnityEngine;

public class PlayerBaseStats : MonoBehaviour
{
    public float health;
    public float score;
    public float speed;
    public float shieldStrength;

    public bool lightShield;
    public bool strongShield;
    public bool scoreIncreased;
    public bool healthChanged;
    public GameObject healthBar;
    public GameObject shieldBar;
    public GameObject SmallShield;
    public GameObject LargeShield;

    [SerializeField]
    GameObject gameManagerObject;
    [SerializeField]
    GameManager gameManager;
    void Start()
    {
        healthBar.GetComponent<HealthBar>().SetStartingHealth(health);
        gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.GetComponent<HealthBar>().SetHealth(health);
        shieldBar.GetComponent<ShieldBar>().SetShield(shieldStrength);
        
        //Update Score
        if (scoreIncreased == true)
        {
            gameManager.updateScore(score);
            scoreIncreased = false;
        }
        //Win Condition
        if (score >= 100 && score <= 249)
        {
            gameManager.currentLevel = 2;
            
        }
        if(score >= 250 && score <= 499)
        {
            gameManager.currentLevel = 3;
        }
        if (score >= 500)
        {
            gameManager.WinScreen();
            
        }
        //Lose Condition
        if (health <= 0)
        {
            gameManager.LoseScreen();
            
        }

    }
}
