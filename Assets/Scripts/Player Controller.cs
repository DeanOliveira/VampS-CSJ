using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private Vector2 movementDirection;

    void OnMove(InputValue value)
    {
        movementDirection = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movementDirection.normalized * speed;
    }
}
