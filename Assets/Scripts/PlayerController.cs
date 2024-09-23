using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText; // Texto pra exibir o Score
    public TextMeshProUGUI timerText;  // Texto para exibir o cronômetro
    private Rigidbody rb;

    private int count;
    private float movementX;
    private float movementY;
    
    public float startTime = 60f;  // Tempo total do jogo (1 minuto)
    private float currentTime; // Inicialização de tempo

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        currentTime = startTime;  // Inicializa o tempo
        SetCountText();
        UpdateTimerText();  // Atualiza o texto do cronômetro
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

    void SetCountText() 
    {
        countText.text = "Score: " + count.ToString();

        if (count >= 7)
        {
            SceneManager.LoadScene(3); 
        }
    }

    void UpdateTimerText()
    {
        
        timerText.text = "Time: " + Mathf.Round(currentTime).ToString() + "s";
    }

    void Update()
    {
        // Atualiza o tempo
        currentTime -= Time.deltaTime;
        UpdateTimerText();

        // Verifica se o tempo acabou
        if (currentTime <= 0)
        {
            // Salva o tempo de partida
            PlayerPrefs.SetFloat("TempoPartida", startTime - currentTime);
            SceneManager.LoadScene(2);  // Se o tempo acabar, vai para a tela de Game Over
        }

        // Verifica se o jogador saiu dos limites do cenário, criei isso porque percebi que existia a possbilidade da bola sair do cenário em teste e ela ficava em queda livre. (Nessa o chat gpt, ajudou pois não achei nada efetivo no youtube ou no google)
        if (rb.position.y < -1f)  // Se o jogador cair abaixo de Y = -1
        {
            // Salva o tempo de partida
            PlayerPrefs.SetFloat("TempoPartida", startTime - currentTime);
            SceneManager.LoadScene(2);  // Vai para a tela de Game Over
        }
    }

    private void FixedUpdate() 
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); 
    }

    void OnTriggerEnter(Collider other) 
    {
        // Para o bloco amarelo (PickUp)
        if (other.gameObject.CompareTag("PickUp")) 
        {
            AudioSource pickupAudioSource = other.gameObject.GetComponent<AudioSource>();
            if (pickupAudioSource != null)
            {
                pickupAudioSource.Play();  
                // Referencia:  https://docs.unity3d.com/ScriptReference/Renderer-enabled.html 
                other.gameObject.GetComponent<MeshRenderer>().enabled = false; 
                // Referencia:  https://docs.unity3d.com/460/Documentation/ScriptReference/Collider-enabled.htm
                other.gameObject.GetComponent<Collider>().enabled = false; 
                StartCoroutine(DeactivateAfterSound(pickupAudioSource, other.gameObject));
            }
            else
            {
                other.gameObject.SetActive(false);  
            }

            count = count + 1;
            SetCountText();
        }

        // Para o bloco vermelho (BlocoVermelho)
        if (other.gameObject.CompareTag("BlocoVermelho")) 
        {
            AudioSource blocoAudioSource = other.gameObject.GetComponent<AudioSource>();
            if (blocoAudioSource != null)
            {
                blocoAudioSource.Play();
                
                // Salva o tempo de partida ao tocar no bloco vermelho
                PlayerPrefs.SetFloat("TempoPartida", startTime - currentTime);
                
                // Esperar a música acabar, mas sem bloquear a movimentação
                StartCoroutine(WaitForMusicToEnd(blocoAudioSource)); 
            }
        }
    }

    // Refeência dos próximos 2 bloco: https://vionixstudio.com/2021/04/03/unity-coroutine-tutorial/
    // Função para desativar o bloco amarelo após o som terminar

    IEnumerator DeactivateAfterSound(AudioSource audioSource, GameObject block)
    {
        yield return new WaitForSeconds(audioSource.clip.length);  
        block.SetActive(false);  
    }

    IEnumerator WaitForMusicToEnd(AudioSource audioSource)
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        SceneManager.LoadScene(2);  
    }
}
