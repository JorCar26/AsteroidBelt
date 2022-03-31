using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    PlayerBaseStats pBaseStats;

    private void Awake()
    {
        pBaseStats = GetComponent<PlayerBaseStats>();
    }
    private void Update()
    {
        if (pBaseStats.health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
