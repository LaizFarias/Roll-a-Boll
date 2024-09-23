using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ManegerYouWin : MonoBehaviour
{
    public TextMeshProUGUI tempoPartidaText;  
    void Start()
    {
 
        float tempoPartida = PlayerPrefs.GetFloat("TempoPartida", 0);
        tempoPartidaText.text = "Tempo de Jogo: " + Mathf.Round(tempoPartida).ToString() + " segundos";
    }

    public void VoltaGame()
    {
        SceneManager.LoadSceneAsync(1);  
    }

    public void SaiGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
