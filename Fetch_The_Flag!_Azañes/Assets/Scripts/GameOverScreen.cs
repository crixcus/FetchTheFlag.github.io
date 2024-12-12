using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    Audio_Screen2 sfx;
    private void Awake()
    {
        sfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_Screen2>();
    }
    public void TryAgainButton()
    {
        FlagCount.Instance.Start();
        SceneManager.LoadScene("Game Map");
    }

    public void MainMenuButton()
    {
        FlagCount.Instance.Start();
        SceneManager.LoadScene("Main Menu");
    }
}
