using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Referencia : https://www.codeease.net/programming/c%23/access-audio-source-from-gameobject-unity
public class ManegerMusic : MonoBehaviour
{
    public AudioSource musicSource;  

    void Start()
    {
        if (musicSource != null)
        {
            Debug.Log("Iniciando a música!!");
            musicSource.Play();
        }
        else
        {
            Debug.LogError("Deu Ruim, A musica !!!!!");
        }
    }
}
