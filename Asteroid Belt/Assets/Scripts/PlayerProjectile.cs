using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    
    [SerializeField]
    float shootSpeed = 1;
    [SerializeField]
    GameObject HitEffect;
    public float damage;
    [SerializeField]
    BoxCollider2D projectileCollider;
    [SerializeField]
    BoxCollider2D shieldCollider;
    void Start()
    {
        projectileCollider = GetComponent<BoxCollider2D>();
        Destroy(this.gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,1,0) * shootSpeed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Instantiate(HitEffect, collision.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
