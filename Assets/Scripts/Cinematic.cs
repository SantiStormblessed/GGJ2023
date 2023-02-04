using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cinematic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitcin());
    }
    IEnumerator waitcin()
    {
        yield return new WaitForSeconds(29f);
        SceneManager.LoadScene("MainScene");
    }

    public void SkipCin()
    {
        StartCoroutine(skip());
    }
    IEnumerator skip()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("MainScene");
    }
}
