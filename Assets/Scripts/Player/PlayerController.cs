using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public int waves = 6;
    public int gold = 12;
    public int life = 15;
    public int enemies = 4;
    public GameObject menuGameOver;
    public GameObject menuWin;
    public float timeForNextWave = 2.2f;
    public Text scoreLife;
    public Text scoreGold;
    public Text scoreWave;
    int factor_enemy = 1;
    // Start is called before the first frame update
    void Start()
    {
        scoreLife.text = life.ToString();
        scoreGold.text = gold.ToString();
        scoreWave.text = waves.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(life > 0 && enemies == 0 && waves > 0)
        {
            waves--;
            enemies = 4*factor_enemy;
            factor_enemy++;
            gold += 3;
            timeForNextWave-= 0.1f;
        }
        if(life > 0)
        {
            scoreLife.text = life.ToString();
            scoreGold.text = gold.ToString();
            scoreWave.text = waves.ToString();
        }
        else if(life <= 0)
        {
            menuGameOver.SetActive(true);
            Time.timeScale = 0; 
        }
        if(waves <= 0)
        {
            menuWin.SetActive(true);
            Time.timeScale = 0; 
        }

    }

   
}
