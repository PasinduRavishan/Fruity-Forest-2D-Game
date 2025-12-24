using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasketController : MonoBehaviour
{
    public Rigidbody2D rBody;
    public float moveSpeed;
    public float minX, maxX;
    public GameManager gameManager;

    private void Update()
    {
        float horizontalInput = 0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
            horizontalInput = -1f;
        else if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
            horizontalInput = 1f;

        rBody.linearVelocity = new Vector2(horizontalInput * moveSpeed, rBody.linearVelocity.y);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fruit"))
        {
            Destroy(collision.gameObject);
            gameManager.score = gameManager.score + 1;

        }
    }
}


