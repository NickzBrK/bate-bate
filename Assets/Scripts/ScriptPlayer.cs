using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    public float velocidade = 20f; // troque pelo valor que você já tem
    private Rigidbody2D rb;
    private Vector2 movimento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
        movimento = movimento.normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimento * velocidade;
    }
}
