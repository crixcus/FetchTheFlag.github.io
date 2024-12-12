using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    public GameObject obj;
    Audio_ sfx;

    private void Awake()
    {
        sfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_>();
    }

    void Update() 
    {
        if (FlagCount.Instance.score < 5)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        sfx.playSFX(sfx.win);
        if (other.CompareTag("FinishLine"))
        {
            Debug.Log("Tapos na yey");
            EndGame();
        }
    }

    private void EndGame()
    {
        sfx.playScreenBgm(sfx.closeBgm);
        Thread.Sleep(3000);
        Debug.Log("Game Over!");
        SceneManager.LoadScene("Game Over Screen"); 
    }
}