using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField] private Transform[] projectileSpawnPoint;
    [SerializeField] private GameObject[] projectilePrefab;
    [SerializeField] private float projectileSpeed = 10f;
    private int random;
    private int fairness;

    void Start() {
        //random = random.Next(6, 15);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            var projectile = Instantiate(projectilePrefab[0], projectileSpawnPoint[0].position, projectileSpawnPoint[0].rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint[0].right * -1f * projectileSpeed;
        }
    }
}
