using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    private float cooldown = 0.5f;
    private float bounce = 20f;

    void Update() {
        if (cooldown <= 0.5f) {
            cooldown += Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if ((collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2")) && collision.gameObject.transform.position.y > transform.position.y) {
            if (cooldown >= 0.5f) {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
                cooldown = 0f;
                }
            }
        }
    }
