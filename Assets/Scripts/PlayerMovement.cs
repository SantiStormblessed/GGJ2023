using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private SpriteRenderer spriteR;
    private float horizontal;
    public float speed = 8f;
    [SerializeField] public float jumpingPower = 32f;
    private float bounce = 20f;
    private bool isFacingRight = true;
    public float notMovingState = 0f;
    private bool endCheck = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded()) {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
        if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f) {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        Flip();
        
        if (notMovingState > 0f) {
            notMovingState -= Time.deltaTime;
        } else MovingAgain();
    }
    private void FixedUpdate() {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    private bool IsGrounded() {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip() { 
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f) {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    public void NotMoving() {
        speed = 0f;
        jumpingPower = 0f;
        notMovingState = 3f;
        spriteR.color = new Color(0.7f, 0.2f, 0.2f, .5f);
    }
    public void MovingAgain() {
        speed = 8f;
        jumpingPower = 32f;
        if (endCheck == true) {
            player.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            endCheck = false;
        }
        spriteR.color = new Color(0.7f, 0.2f, 0.2f, 1f);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Projectile")) {
            NotMoving();
        }
        if (collision.gameObject.CompareTag("EndPlatform")) {
            NotMoving();
            endCheck = true;
        }
    }
}
