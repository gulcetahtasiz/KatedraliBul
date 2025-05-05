using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SudokuPuzzleController : MonoBehaviour
{
    public SudokuCell[] cells;
    public GameObject puzzleUI;
    public GameObject successPanel;
    public GameObject victoryPanel;

    public void CheckPuzzle()
    {
        foreach (SudokuCell cell in cells)
        {
            if (!cell.IsCorrect())
            {
                return; 
            }
        }



        successPanel.SetActive(true);

        Invoke("ShowVictory", 2f);
    }

    void ShowVictory()
    {
        puzzleUI.SetActive(false);
        victoryPanel.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
