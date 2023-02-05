using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private SpriteRenderer spriteR;
    private float horizontal;
    public float speed = 8f;
    [SerializeField] public float jumpingPower = 100f;
    private float bounce = 20f;
    private bool isFacingRight = false;
    public float notMovingState = 0f;
    private bool endCheck = false;
    [SerializeField] private Animator animator;
    public bool whichPlayer;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public AudioClip hurtClipBlue;
    public AudioClip hurtClipRed;
    public AudioClip jumpClip;

    AudioSource audioSource;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        if (whichPlayer == true) {
            horizontal = Input.GetAxisRaw("HorizontalBlue");
            if (Input.GetButtonDown("JumpBlue") && IsGrounded()) {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                audioSource.PlayOneShot(jumpClip);
            }
            if (Input.GetButtonDown("JumpBlue") && rb.velocity.y > 0f) {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
                audioSource.PlayOneShot(jumpClip);
            }
        } else {
            horizontal = Input.GetAxisRaw("HorizontalRed");
            if (Input.GetButtonDown("JumpRed") && IsGrounded()) {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                audioSource.PlayOneShot(jumpClip);
            }
            if (Input.GetButtonDown("JumpRed") && rb.velocity.y > 0f) {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
                audioSource.PlayOneShot(jumpClip);
            }
        }
        if (rb.velocity.magnitude == 0f) animator.SetBool("IsFlying", false);
        else animator.SetBool("IsFlying", true);
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
        spriteR.color = new Color(1f, 1f, 1f, .5f);
    }
    public void MovingAgain() {
        speed = 8f;
        jumpingPower = 32f;
        if (endCheck == true) {
            player.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
            endCheck = false;
        }
        spriteR.color = new Color(1f, 1f, 1f, 1f);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Projectile")) {
            NotMoving();

            if(whichPlayer) audioSource.PlayOneShot(hurtClipBlue);
            else audioSource.PlayOneShot(hurtClipRed);
        }
        if (collision.gameObject.CompareTag("EndPlatform")) {
            NotMoving();

            if(whichPlayer) audioSource.PlayOneShot(hurtClipBlue);
            else audioSource.PlayOneShot(hurtClipRed);
            endCheck = true;
        }
        
    }
}
