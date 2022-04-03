using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyList;
    public float waitTime;
    float elapsedTime;
    float spawnX;
    float spawnY;
    Transform spawnPoint;

    void Start()
    {
        spawnX = Random.Range(-8.3f, 8.3f);
        spawnY = Random.Range(5.5f, 7.5f);
        StartCoroutine(EnemyWave(waitTime));
    }

    void spawnEnemy()
    {
        GameObject enemy = Instantiate(enemyList[Random.Range(0, enemyList.Count)]);
        enemy.transform.position = new Vector2(spawnX, spawnY);
        
    }
    public IEnumerator EnemyWave(float waitTime)
    {
        spawnX = Random.Range(-8.3f, 8.3f);
        spawnY = Random.Range(5.5f, 7.5f);
        spawnEnemy();
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(EnemyWave(waitTime));


    }
}
