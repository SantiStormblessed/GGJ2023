using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float life = 3f;
    private Transform playerTransform;
    private float notMovingState = 0f;

    void Awake() {
        Destroy(gameObject, life);
        playerTransform = FindObjectOfType<PlayerMovement>().GetPlayer();
    }
    void Start() {
        Debug.Log(playerTransform);
    }
    void Update() {
        if (notMovingState > 0f) {
            notMovingState -= Time.deltaTime;
        } //else playerMovement.MovingAgain();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            //playerTransform
            //playerMovement.NotMoving();
            notMovingState = 3f;
        }
    }
    
}
