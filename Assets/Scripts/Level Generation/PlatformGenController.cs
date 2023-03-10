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

    public float maxDistance = 3;

    float currHeight = -2f;

    int platformType;

    Rigidbody2D playerRB;

    void Start()
    {
        //zona 1
        while (currHeight <= 15f){
            Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            currHeight += Random.Range(1f, maxDistance);
        }

        while (currHeight <= 35f){
            platformType = Random.Range(1, 11);
            if(platformType <= 6){
                Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            }
            else{
                Instantiate(movingPlatform, new Vector3(Random.Range(-6f, -2f), currHeight, 0), Quaternion.identity);
            }

            currHeight += Random.Range(1f, maxDistance);
        }
        //zona 2

        while (currHeight <= 75f){
            platformType = Random.Range(1, 11);
            if (platformType <= 5){
                Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            }
            else if(platformType <= 8){
                Instantiate(movingPlatform, new Vector3(Random.Range(-6f, -2f), currHeight, 0), Quaternion.identity);
            }
            else{
                Instantiate(brokenPlatform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            }

            currHeight += Random.Range(1f, maxDistance);
        }

        //zona 3

        while (currHeight <= 135f){
            platformType = Random.Range(1, 11);
            if (platformType <= 5){
                Instantiate(platform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            }
            else if(platformType <= 7 && platformType > 5){
                Instantiate(movingPlatform, new Vector3(Random.Range(-6f, -2f), currHeight, 0), Quaternion.identity);
            }
            else if(platformType == 8){    
                Instantiate(brokenPlatform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            }
            else{
                Instantiate(cloudPlatform, new Vector3(Random.Range(-7.882f, -1.254f), currHeight, 0), Quaternion.identity);
            }

            currHeight += Random.Range(1f, maxDistance);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
