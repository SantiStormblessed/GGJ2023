using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCheck : MonoBehaviour
{
    [SerializeField] GameObject projectileShooter;
    ProjectileShooter PS;

    void Start()
    {
        PS = projectileShooter.GetComponent<ProjectileShooter>();
    }

    void Update()
    {
        if(transform.position.y >= -75f && transform.position.y <= -35f){
            PS.level = 1;
        }
        else if(transform.position.y < -75f){
            PS.level = 2;
        }
    }
}
