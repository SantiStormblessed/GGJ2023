using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    private float bounce = 20f;
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if((collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2")) && collision.gameObject.transform.position.y > transform.position.y) { 
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}
