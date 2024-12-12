using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "FinishLine")
        {
            Debug.Log("Gana");
            Debug.Log("Tapos na yey");
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over!");

        SceneManager.LoadScene("Game Over Screen");
        Application.Quit();
    }
}
