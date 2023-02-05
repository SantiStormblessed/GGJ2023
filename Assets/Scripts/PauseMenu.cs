using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private AudioMixer audioMixer2;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuUI2;
    public GameObject pauseButton;

    void Start()
    {
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        } 

    }
    
    // Start is called before the first frame update
   
 
    public void CambiarVolumenMusica(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
    public void CambiarVolumenSonidos(float volumen)
    {
        audioMixer2.SetFloat("Volumen2", volumen);
    }
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenuUI2.SetActive(true);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        pauseMenuUI2.SetActive(false);
    }
    public void VolverMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
