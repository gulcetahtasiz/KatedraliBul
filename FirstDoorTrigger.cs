using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoorTrigger : MonoBehaviour
{
    public GameObject puzzleUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puzzleUI.SetActive(true);  
            Time.timeScale = 1f;       
        }
    }
}
