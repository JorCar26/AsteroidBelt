using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZones : MonoBehaviour
{
    [SerializeField]
    GameObject gameManagerObject;
    [SerializeField]
    GameManager gameManager;
    void Start()
    {
        gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameManager.KillBoxScreen();
            
            Destroy(collision.gameObject);
        }
    }
}
