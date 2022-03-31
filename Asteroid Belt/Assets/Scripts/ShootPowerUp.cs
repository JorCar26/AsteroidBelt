using UnityEngine;

public class ShootPowerUp : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    float timeAllowed;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerShooting>().powerUpTimer = 0;
            player.GetComponent<PlayerShooting>().amountOfTimeAllowed = timeAllowed;
            player.GetComponent<PlayerShooting>().fireDouble = true;
            Destroy(this.gameObject);
        }
    }
}
