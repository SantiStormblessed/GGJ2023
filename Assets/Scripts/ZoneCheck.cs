using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCheck : MonoBehaviour
{
    [SerializeField] GameObject projectileShooter;
    ProjectileShooter PS;

    // Start is called before the first frame update
    void Start()
    {
        PS = projectileShooter.GetComponent<ProjectileShooter>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);
        if(transform.position.y >= -75f && transform.position.y <= -35f){
            PS.level = 1;
        }
        else if(transform.position.y < -75f){
            Debug.Log("trigereao");
            PS.level = 2;
        }
    }
}
