using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    EnemyBaseStats eBaseStats;
    [SerializeField]
    GameObject player;
    [SerializeField]
    PlayerBaseStats pBaseStats;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pBaseStats = player.GetComponent<PlayerBaseStats>();
        eBaseStats = GetComponent<EnemyBaseStats>();
        
        
    }
    void Update()
    {
        if(eBaseStats.health <= 0)
        {
            pBaseStats.score += eBaseStats.score;
            pBaseStats.scoreIncreased = true;
            Destroy(this.gameObject,0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            eBaseStats.health -= collision.gameObject.GetComponent<PlayerProjectile>().damage;
        }

        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(this.gameObject, 2.0f);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<BoxCollider2D>(), collision.gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
