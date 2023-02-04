using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private AudioMixer audioMixer2;
    // Start is called before the first frame update
    public void CambiarVolumenMusica(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
    public void CambiarVolumenSonidos(float volumen)
    {
        audioMixer2.SetFloat("Volumen2", volumen);
    }
}
