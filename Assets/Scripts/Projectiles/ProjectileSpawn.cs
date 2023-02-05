using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] projectileSpawnPoint;
    [SerializeField] private Transform player;

    void Update() {
        for (int i = 0; i < projectileSpawnPoint.Length; i++) {
            projectileSpawnPoint[i].position = new Vector3(projectileSpawnPoint[i].position.x, player.position.y + 1, projectileSpawnPoint[i].position.z);
        }
        
    }
}
