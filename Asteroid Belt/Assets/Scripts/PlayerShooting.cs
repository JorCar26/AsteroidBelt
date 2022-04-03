using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    GameObject projectilePrefab;
    [SerializeField]
    Transform singleShootPoint;
    [SerializeField]
    Transform doubleShootPoint;
    [SerializeField]
    float elapsedTime;
    public float powerUpTimer;
    [SerializeField]
    float rateOfFire;
    public float amountOfTimeAllowed;
    public AudioClip clip;
    public AudioSource audioSource;
    public bool fireSingle;
    public bool fireDouble;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        powerUpTimer += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && (elapsedTime >= rateOfFire))
        {
            if(fireDouble != true)
            {
                Instantiate(projectilePrefab, singleShootPoint.position, singleShootPoint.rotation);
                audioSource.PlayOneShot(clip, 0.5f);
                elapsedTime = 0.0f;
            }
            else
            {
                Instantiate(projectilePrefab, doubleShootPoint.position, singleShootPoint.rotation);
                Instantiate(projectilePrefab, doubleShootPoint.GetChild(0).position, doubleShootPoint.GetChild(0).rotation);
                audioSource.PlayOneShot(clip, 0.5f);
                elapsedTime = 0.0f;
            }
        }
        if(powerUpTimer > amountOfTimeAllowed && fireDouble == true)
        {
            fireDouble = false;
        }
    }
}
