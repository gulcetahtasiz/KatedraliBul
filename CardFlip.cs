using UnityEngine;
using UnityEngine.UI;

public class CardFlip : MonoBehaviour
{
    public Sprite frontSprite;
    public Sprite backSprite;

    private Image image;
    private bool isFlipped = false;

    public bool IsMatched { get; set; } = false;
    public Sprite FrontSprite => frontSprite;

    void Awake()
    {
        image = GetComponent<Image>();
    }

    void OnEnable()
    {
        FlipBack();
    }

    public void OnClick()
    {
        if (!isFlipped && !IsMatched && MemoryPuzzleController.instance != null)
        {
            MemoryPuzzleController.instance.CardClicked(this);
        }
    }

    public void FlipFront()
    {
        image.sprite = frontSprite;
        isFlipped = true;
    }

    public void FlipBack()
    {
        image.sprite = backSprite;
        isFlipped = false;
    }
}
