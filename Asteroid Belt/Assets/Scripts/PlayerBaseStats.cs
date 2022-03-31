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
        //Update Health Bar
        if(healthChanged == true)
        {
            healthBar.GetComponent<HealthBar>().SetHealth(health);
            Debug.Log("Health Lost");
            healthChanged = false;
        }
        //Update Score
        if (scoreIncreased == true)
        {
            gameManager.updateScore(score);
            scoreIncreased = false;
        }
        //Win Condition
        if(score >= 5000)
        {
            gameManager.WinScreen();
        }
        //Lose Condition
        if(health <= 0)
        {
            gameManager.LoseScreen();
        }
        if(shieldStrength == 25)
        {
            lightShield = true;
        }
        if(shieldStrength == 50)
        {
            strongShield = true;
        }
        if (lightShield == true)
        {
            SmallShield.SetActive(true);
        }
        if(strongShield == true)
        {
            LargeShield.SetActive(true);
        }

    }
}
