using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPause : MonoBehaviour
{
    public GameObject panel;
    public Button button;
    public Sprite Pause;
    public Sprite Play;
    public void pauseGame()
    {
        if (Time.timeScale == 1) 
        {
            button.GetComponent<Image>().sprite = Play;
            panel.SetActive(true);
            Time.timeScale = 0; 
        }
        else if (Time.timeScale == 0)
        {
            button.GetComponent<Image>().sprite = Pause;
            panel.SetActive(false);
            Time.timeScale = 1; 
        }
    }
}
