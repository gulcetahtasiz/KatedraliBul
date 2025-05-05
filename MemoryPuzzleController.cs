using UnityEngine;
using System.Collections;

public class MemoryPuzzleController : MonoBehaviour
{
    public static MemoryPuzzleController instance;

    private CardFlip firstCard = null;
    private CardFlip secondCard = null;
    private bool canClick = true;

    public int totalCardCount = 8;
    private int matchedCardCount = 0;

    public GameObject puzzleUI;
    public GameObject victoryText;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void CardClicked(CardFlip clickedCard)
    {
        if (!canClick || clickedCard == null || clickedCard == firstCard)
            return;

        if (firstCard == null)
        {
            firstCard = clickedCard;
            firstCard.FlipFront();
        }
        else
        {
            secondCard = clickedCard;
            secondCard.FlipFront();
            StartCoroutine(CheckMatch());
        }
    }

    IEnumerator CheckMatch()
    {
        canClick = false;
        yield return new WaitForSecondsRealtime(1f);

        if (firstCard.FrontSprite == secondCard.FrontSprite)
        {
            firstCard.IsMatched = true;
            secondCard.IsMatched = true;
            matchedCardCount += 2;

            if (matchedCardCount >= totalCardCount)
            {
                victoryText.SetActive(true);
                yield return new WaitForSecondsRealtime(2f);
                victoryText.SetActive(false); 
                puzzleUI.SetActive(false);
            }
        }
        else
        {
            firstCard.FlipBack();
            secondCard.FlipBack();
        }

        firstCard = null;
        secondCard = null;
        canClick = true;
    }
}
