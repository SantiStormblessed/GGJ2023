using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenController : MonoBehaviour
{
    [SerializeField] GameObject player;

    PlatformFall PlatformFall;
    Rigidbody2D playerRB;
    //float playerHeight = 0;


    void Start()
    {
        playerRB = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
