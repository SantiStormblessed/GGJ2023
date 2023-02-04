using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject platform;
    [SerializeField] GameObject brokenPlatform;
    [SerializeField] GameObject cloudPlatform;
    [SerializeField] GameObject movingPlatform;

    float currHeight = -3f;

    Rigidbody2D playerRB;

    void Start()
    {
        while (currHeight <= 35f){
            Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.006f), currHeight, 0), Quaternion.identity);
            currHeight += Random.Range(1f, 3.3f);
        }

        while (currHeight <= 75f){
            Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.006f), currHeight, 0), Quaternion.identity);
            currHeight += Random.Range(1f, 3.3f);
        }

        while (currHeight <= 115f){
            Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.006f), currHeight, 0), Quaternion.identity);
            currHeight += Random.Range(1f, 3.3f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
