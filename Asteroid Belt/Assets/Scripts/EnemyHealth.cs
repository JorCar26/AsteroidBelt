using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    EnemyBaseStats eBaseStats;
    [SerializeField]
    GameObject player;
    [SerializeField]
    PlayerBaseStats pBaseStats;
    [SerializeField]
    GameObject enemy;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pBaseStats = player.GetComponent<PlayerBaseStats>();
        eBaseStats = enemy.GetComponent<EnemyBaseStats>();


    }

    private void OnEnable()
    {
        eBaseStats.health = eBaseStats.maxHealth;
    }

    void Update()
    {
        if (eBaseStats.health <= 0)
        {
            pBaseStats.score += eBaseStats.score;
            pBaseStats.scoreIncreased = true;
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            eBaseStats.health -= collision.gameObject.GetComponent<PlayerProjectile>().damage;
        }

        if (collision.gameObject.tag == "Boundary")
        {
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<BoxCollider2D>(), collision.gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
