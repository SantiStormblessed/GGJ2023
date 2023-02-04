using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{

    GameObject player;

    Rigidbody2D playerRB;

    public int whichPlayer = 1;

    public float FallSpeed = 0.9f;

    void Start()
    {
        if (whichPlayer == 1){
            player = GameObject.FindWithTag("Player");
        }
        else{
            player = GameObject.FindWithTag("Player2");
        }
        playerRB = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRB.position.y >= 0){
            Fall();
        }
    }

    public void Fall(){
        transform.position -= new Vector3(0, FallSpeed * Time.deltaTime,0);
    }
}
