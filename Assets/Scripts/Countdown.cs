using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    [SerializeField] private PlayerMovement[] player;
    [SerializeField] private GameObject[] images;
    private float timer;

    void Start() {
        for (int i = 0; i < player.Length; i++) {
            player[i].NotMoving();
        }
    }

    void Update() {
        if (timer < 3f) timer += Time.deltaTime;
        images[0].SetActive(true);
        if (timer >= 1f) {
            images[0].SetActive(false);
            images[1].SetActive(true);
        } if (timer >= 2f) {
            images[1].SetActive(false);
            images[2].SetActive(true);
        } if (timer >= 3f) {
            images[2].SetActive(false);
        }
    }
}
