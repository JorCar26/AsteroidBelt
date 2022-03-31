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
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(waitTime <= elapsedTime)
        {
            spawnX = Random.Range(-8.3f, 8.3f);
            spawnY = Random.Range(5.5f, 7.5f);
            StartCoroutine(EnemyWave(waitTime));
            elapsedTime = 0;
        }
    }
    void spawnEnemy()
    {
        GameObject enemy = Instantiate(enemyList[Random.Range(0, enemyList.Count)]);
        enemy.transform.position = new Vector2(spawnX, spawnY);
        
    }
    IEnumerator EnemyWave(float waitTime)
    {
        
        spawnEnemy();
        yield return new WaitForSeconds(waitTime);
            

    }
}
