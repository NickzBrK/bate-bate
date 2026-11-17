using UnityEngine;

public class ScriptCarrinhos : MonoBehaviour
{
    public float minSpeed = 100f;
    public float maxSpeed = 700f;

    //public float minScale = 1.0f;
    //public float maxScale = 2.5f;
    

    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // float randomSize = Random.Range(minScale, maxScale);
        //transform.localScale = new Vector3(randomSize, randomSize, 1f);

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Vector2 randomDirection = Random.insideUnitCircle;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(randomDirection * randomSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
