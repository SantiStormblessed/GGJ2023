using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatform : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMov;

    void OnColissionEnter2D() {
        playerMov.NotMoving();

    }

}
