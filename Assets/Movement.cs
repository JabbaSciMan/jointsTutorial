using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float flightSpeed = 5.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1f;
        }

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, flightSpeed);
        }
    }
}
