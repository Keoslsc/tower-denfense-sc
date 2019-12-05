using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    private Scene scene;
    public GameObject mainMenu;
    public GameObject gameWin;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(scene.name);
        mainMenu.SetActive(true);
        gameWin.SetActive(false);
        gameOver.SetActive(false);
    }
}
