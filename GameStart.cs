using UnityEngine;
using UnityEngine.UI;

public class GameStartUI : MonoBehaviour
{
    public GameObject startPanel;

    // Statik bayrak: oyun başladı mı?
    public static bool gameStarted = false;

    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1f;
        gameStarted = true; // oyun artık başladı
    }

    void Start()
    {
        if (gameStarted)
        {
            startPanel.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
            startPanel.SetActive(true);
        }
    }
}
