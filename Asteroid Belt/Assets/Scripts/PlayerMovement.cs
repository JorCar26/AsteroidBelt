using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    PlayerBaseStats pBaseStats;
    [SerializeField]
    EnemyBaseStats eBaseStats;
    private void Awake()
    {
        pBaseStats = GetComponent<PlayerBaseStats>();
    }
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime * pBaseStats.speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyProjectile" || collision.gameObject.tag == "Enemy")
        {
            eBaseStats = collision.gameObject.GetComponent<EnemyBaseStats>();
            pBaseStats.health -= eBaseStats.damage;
        }
    }
}
