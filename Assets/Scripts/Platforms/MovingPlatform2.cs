using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject EdgeRight;
    [SerializeField] GameObject EdgeLeft;

    void Start() {

    }
    void Update() {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (EdgeLeft.transform.position.x <= -8.882f || EdgeRight.transform.position.x >= 0.12f){
            speed = -speed;
        }
    }

}
