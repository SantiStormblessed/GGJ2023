using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{

    void Update()
    {
         transform.Rotate(new Vector3(0,0,20) * Time.deltaTime);
    }
}
