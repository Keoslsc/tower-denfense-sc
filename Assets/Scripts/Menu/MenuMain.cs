using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMain : MonoBehaviour
{
    public GameObject panel;
    public GameObject music;
    public Button play;
    public Button quit;

    void Start()
    {
        Time.timeScale = 0; 
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void startGame()
    {
        Time.timeScale = 1;
        Instantiate(music);
        panel.SetActive(false);
    }
}
