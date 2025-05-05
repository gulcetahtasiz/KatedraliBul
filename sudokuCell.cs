using UnityEngine;
using TMPro;

public class SudokuCell : MonoBehaviour
{
    public int correctValue; 
    public bool isLocked;    
    public TMP_InputField inputField;

    void Start()
    {
        if (isLocked)
        {
            inputField.text = correctValue.ToString();
            inputField.interactable = false; 
        }
        else
        {
            inputField.text = "";
            inputField.interactable = true;
        }
    }

    public bool IsCorrect()
    {
        return inputField.text == correctValue.ToString();
    }
}

