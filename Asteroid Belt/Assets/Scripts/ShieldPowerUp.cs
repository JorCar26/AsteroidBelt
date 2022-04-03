using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    public GameObject shieldBar;
    PlayerBaseStats pBaseStats;
    [SerializeField]
    float ShieldStrength;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        shieldBar = GameObject.FindGameObjectWithTag("ShieldBar");
        pBaseStats = player.GetComponent<PlayerBaseStats>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           pBaseStats.shieldStrength = ShieldStrength;
            if (ShieldStrength== 25)
            {
                pBaseStats.SmallShield.SetActive(true);
                shieldBar.GetComponent<ShieldBar>().SetShieldMax(ShieldStrength);
                pBaseStats.lightShield = true;
            }
            if (ShieldStrength == 50)
            {
                pBaseStats.LargeShield.SetActive(true);
                shieldBar.GetComponent<ShieldBar>().SetShieldMax(ShieldStrength);
                pBaseStats.strongShield = true;
            }
            Destroy(this.gameObject);
        }
    }
}
