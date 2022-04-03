using UnityEngine;

public class HitEffect : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 0.05f);
    }

}
