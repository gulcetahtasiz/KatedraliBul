using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject puzzleUI;
    public Animator doorAnimator;

    public void OnPuzzleSolved()
    {
        puzzleUI.SetActive(false);     
        Time.timeScale = 1f;           
    }
}
