using UnityEngine;

public class PuzzleUIController : MonoBehaviour
{
    public GameObject puzzleUI;
    public GameObject startPuzzleButton;

    public void OpenPuzzle()
    {
        puzzleUI.SetActive(true);
        startPuzzleButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ClosePuzzle()
    {
        puzzleUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
