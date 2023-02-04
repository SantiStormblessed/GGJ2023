using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float life = 3f;

    void Awake() {
        Destroy(gameObject, life);
    }
}
