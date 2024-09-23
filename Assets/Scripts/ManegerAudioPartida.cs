using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManegerAudioPartida : MonoBehaviour
{
    public AudioSource musicSource;  

    void Start()
    {
        if (musicSource == null)
        {
            Debug.LogError("Deu Ruim, A música não foi atribuída no Inspector!");
        }
        else
        {
            Debug.Log("Iniciando a música!");
            musicSource.Play();
        }
    }

}
