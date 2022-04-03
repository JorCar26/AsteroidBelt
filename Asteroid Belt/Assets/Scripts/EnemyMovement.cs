using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    float enemySpeed;
    [SerializeField]
    EnemyBaseStats eBaseStats;

    float spawnX;
    float spawnY;
    private void Awake()
    {
        eBaseStats = GetComponent<EnemyBaseStats>();
    }

    private void OnEnable()
    {
        spawnX = Random.Range(-8.3f, 8.3f);
        spawnY = Random.Range(5.5f, 7.5f);
        transform.position = new Vector2(spawnX, spawnY);
    }
    void Start()
    {
        enemySpeed = eBaseStats.moveSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * enemySpeed * Time.deltaTime;
    }
}
