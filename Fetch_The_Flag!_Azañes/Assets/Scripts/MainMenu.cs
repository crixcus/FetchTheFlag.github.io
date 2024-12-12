using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    Audio_Screens sfx;
    void Awake()
    {
        sfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_Screens>();
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed.");
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Game Map");
    }
}
