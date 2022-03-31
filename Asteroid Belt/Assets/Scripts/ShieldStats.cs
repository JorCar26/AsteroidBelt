using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldStats: MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject Shield;

    private void Update()
    {
        if(player.GetComponent<PlayerBaseStats>().shieldStrength == 0)
        {
            player.GetComponent<PlayerBaseStats>().lightShield = false;
            player.GetComponent<PlayerBaseStats>().strongShield = false;
            Shield.SetActive(false);
        }
    }
}
