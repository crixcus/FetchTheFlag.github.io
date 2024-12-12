using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    Audio_ sfx;

    private void Awake()
    {
        sfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_>();
    }
    private void OnTriggerEnter2D(Collider2D ohno)
    {
        if (ohno.gameObject.tag == "Out")
        {
            Debug.Log("Lose");
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("Game Over Screen");
        sfx.playScreenBgm(sfx.closeBgm);
    }
}
