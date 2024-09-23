using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicYouWin : MonoBehaviour
{
    public AudioSource musicSource;  

    void Start()
    {
        if (musicSource == null)
        {
            Debug.LogError("Deu Ruim, A música !");
        }
        else
        {
            Debug.Log("Iniciando a música!");
            musicSource.Play();
        }
    }
}
