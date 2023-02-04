using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float life = 3f;
    //private Transform playerTransform;

    void Awake() {
        Destroy(gameObject, life);
        //playerTransform = FindObjectOfType<PlayerMovement>().GetPlayer();
    }

    //se pueden borrar pero ajá XD
    /*void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) { 
        }
    }*/
    
}
