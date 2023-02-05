using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float life = 1f;

    void Awake() {
        Destroy(gameObject, life);
    }

    void OnCollisionStay2D(Collision2D other) {
        if ((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Player2"))){
            Destroy(gameObject);
        }
    }
}
