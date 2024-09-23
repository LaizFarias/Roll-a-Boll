using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGameOver : MonoBehaviour
{
    public AudioSource musicSource;  

    void Start()
    {
        if (musicSource == null)
        {
            Debug.LogError("Deu Ruim, na musica!");
        }
        else
        {
            Debug.Log("Iniciando a música!");
            musicSource.Play();
        }
    }
}
