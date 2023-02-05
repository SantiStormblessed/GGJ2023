using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField] private Transform[] projectileSpawnPoint;
    [SerializeField] private GameObject[] projectilePrefab;
    [SerializeField] private float projectileSpeed = 10f;
    private int fairness, level = 0, spawnPoint, spawnPointCheck = 0;
    [SerializeField] private float spawnTime;
    private float spawnTimer;

    void Start() {
        spawnTime = Random.Range(6f, 15f);
        spawnPoint = Random.Range(0, 2);
    }

    void Update() {
        if (spawnPointCheck == spawnPoint) {
            fairness++;
        }
        if (fairness >= 4) {
            fairness = 0;
            if (spawnPoint == 0) spawnPoint = 1;
            else spawnPoint = 0;
        }
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTime) ShootProjectile();
    }
    void ShootProjectile() {
        
        if (spawnPoint == 1) {
            var projectile = Instantiate(projectilePrefab[level], projectileSpawnPoint[spawnPoint].position, projectileSpawnPoint[spawnPoint].rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint[spawnPoint].right * -1f * projectileSpeed;
        } else {
            var projectile = Instantiate(projectilePrefab[level], projectileSpawnPoint[spawnPoint].position, projectileSpawnPoint[spawnPoint].rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint[spawnPoint].right * projectileSpeed;
        }

        spawnPointCheck = spawnPoint;

        spawnTime = Random.Range(6f, 15f);
        spawnPoint = Random.Range(0, 2);
        spawnTimer = 0f;
    }
}
