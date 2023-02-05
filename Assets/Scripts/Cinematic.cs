using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cinematic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        if (SceneManager.GetActiveScene().name == "Cinematic") StartCoroutine(waitcin());
        else StartCoroutine(waitwin());

    }
    IEnumerator waitcin() {
        yield return new WaitForSeconds(28f);
        SceneManager.LoadScene("MainScene");
    }
    IEnumerator waitwin() {
        yield return new WaitForSeconds(5.25f);
        SceneManager.LoadScene("MainScene");
    }
    public void SkipCin() {
        StartCoroutine(skip());
    }
    IEnumerator skip() {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("MainScene");
    }
}
