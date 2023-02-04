using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenController2 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject platform;
    [SerializeField] GameObject brokenPlatform;
    [SerializeField] GameObject cloudPlatform;
    [SerializeField] GameObject movingPlatform;

    float currHeight = -3f;

    int platformType;

    Rigidbody2D playerRB;

    void Start()
    {
        //zona 1
        while (currHeight <= 15f){
            Instantiate(platform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            currHeight += Random.Range(1f, 3f);
        }

        while (currHeight <= 35f){
            platformType = Random.Range(1, 11);

            if(platformType <= 6){
                Instantiate(platform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            }
            else{
                Instantiate(movingPlatform, new Vector3(4f, currHeight, 0), Quaternion.identity);
            }

            currHeight += Random.Range(1f, 3f);
        }
        //zona 2

        while (currHeight <= 75f){
            platformType = Random.Range(1, 11);
    
            if (platformType <= 5){
                Instantiate(platform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            }
            else if(platformType <= 8 && platformType > 5){
                Instantiate(movingPlatform, new Vector3(4f, currHeight, 0), Quaternion.identity);
            }
            else{
                Instantiate(brokenPlatform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            }

            currHeight += Random.Range(1f, 3f);
        }

        //zona 3

        while (currHeight <= 115f){
            platformType = Random.Range(1, 11);
    
            if (platformType <= 5){
                Instantiate(platform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            }
            else if(platformType <= 8 && platformType > 5){
                Instantiate(movingPlatform, new Vector3(4f, currHeight, 0), Quaternion.identity);
            }
            else if(platformType == 9){    
                Instantiate(brokenPlatform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            }
            else{
                Instantiate(cloudPlatform, new Vector3(Random.Range(1.006f, 7.882f), currHeight, 0), Quaternion.identity);
            }

            currHeight += Random.Range(1f, 3f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
