using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, -1, 0) * 5 * Time.deltaTime;
    }
}
