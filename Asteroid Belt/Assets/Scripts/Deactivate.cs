using UnityEngine;

public class Deactivate : MonoBehaviour
{
    public float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 2 )
        {
            elapsedTime = 0;
            Destroy(this.gameObject);
        }
    }
}
