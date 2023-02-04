using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField] private Transform projectileSpawnPoint;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float projectileSpeed = 10f;

    void Update() {
        if (Input.GetKeyDown(KeyCode.L)) {
            var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint.right * -1f * projectileSpeed;
        }
    }
}
