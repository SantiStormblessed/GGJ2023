using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    [SerializeField] private Transform[] sun;
    [SerializeField] private Transform progress;
    [SerializeField] private float positionX;

    void Update() {
        for (int i = 0; i < sun.Length; i++) {
            sun[i].position = new Vector3(positionX, progress.position.y, 0f);
        }
    }
}
