using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public List<GameObject> enemyList;
    public float waitTime;

    [SerializeField] [Range(0, 50)] int poolSize = 5;

    GameObject[] pool;
    public GameManager manager;

    void Start()
    {
        PopulatePool();
        StartCoroutine(EnemyWave(waitTime));
    }
    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemyList[Random.Range(0, enemyList.Count)]);
            pool[i].SetActive(false);
        }
    }

    void EnableObjectInPool()
    {
        for (int i = 0; i < pool.Length; i++)
        {
            if (pool[i].activeInHierarchy == false)
            {
                pool[i].SetActive(true);
                return;
            }

        }
    }

    public IEnumerator EnemyWave(float waitTime)
    {
        while (manager.GameRunning == true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(waitTime);
            //StartCoroutine(EnemyWave(waitTime));
        }

    }
}
