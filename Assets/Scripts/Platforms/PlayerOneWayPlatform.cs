using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneWayPlatform : MonoBehaviour
{
    private GameObject currentOneWayPlatform;
    [SerializeField] private BoxCollider2D playerCollider;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("OneWayPlatform")) {
           currentOneWayPlatform = collision.gameObject;
        }
    }
    private void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("OneWayPlatform")) {
            currentOneWayPlatform = null;
        }
    }
}
