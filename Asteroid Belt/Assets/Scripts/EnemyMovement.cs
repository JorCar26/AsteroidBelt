using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    float enemySpeed;
    [SerializeField]
    EnemyBaseStats eBaseStats;
    private void Awake()
    {
        eBaseStats = GetComponent<EnemyBaseStats>();
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
