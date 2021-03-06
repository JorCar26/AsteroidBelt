using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public List<GameObject> powerUpList;
    public float waitTime;
    float elapsedTime;
    float spawnX;
    float spawnY;

    void Start()
    {

        spawnX = Random.Range(-9.3f, 9.3f);
        spawnY = Random.Range(5.5f, 7.5f);
        StartCoroutine(dropPowerUp(waitTime));
    }

    void spawnPowerUp()
    {
        GameObject enemy = Instantiate(powerUpList[Random.Range(0, powerUpList.Count - 1)]);
        enemy.transform.position = new Vector2(spawnX, spawnY);

    }
    IEnumerator dropPowerUp(float waitTime)
    {
        spawnX = Random.Range(-9.3f, 9.3f);
        spawnY = Random.Range(5.5f, 7.5f);
        spawnPowerUp();
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(dropPowerUp(waitTime));


    }
}
