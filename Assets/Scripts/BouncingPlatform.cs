using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    private float bouce = 20f;
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Player")) { 
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bouce, ForceMode2D.Impulse);
        }
    }
}
