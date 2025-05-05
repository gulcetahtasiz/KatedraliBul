using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SecondDoorTrigger : MonoBehaviour
{
    public GameObject sudokuPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            sudokuPanel.SetActive(true); 
        }
    }
}

