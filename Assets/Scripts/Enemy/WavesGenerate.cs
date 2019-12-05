using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavesGenerate : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject source;
    public Text wavesTime;
    int waves;
    int enemies;
    public float timeForNextWave; 
    // Start is called before the first frame update
    void Start()
    {
        waves = player.GetComponent<PlayerController>().waves;
        enemies = player.GetComponent<PlayerController>().enemies;
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        waves = player.GetComponent<PlayerController>().waves;
        enemies = player.GetComponent<PlayerController>().enemies;
        if(enemies == 0)
        {
            StartCoroutine(StartCountdown());
        }
    }

    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        wavesTime.enabled = true;
        timeForNextWave = countdownValue;
        while (timeForNextWave > 0)
        {
            wavesTime.text = timeForNextWave.ToString("00");
            yield return new WaitForSeconds(1.0f);
            timeForNextWave--;
        }
        if(timeForNextWave == 0)
        {
            StartCoroutine(StartWave(enemies));
        }
        wavesTime.enabled = false;
    }

    public IEnumerator StartWave(int enemies = 4)
    {
        int enemyWave = enemies;
        while (enemyWave > 0 && waves > 0)
        {
            yield return new WaitForSeconds(player.GetComponent<PlayerController>().timeForNextWave);
            GameObject temp = Instantiate(enemy, source.transform.position, source.transform.rotation);
            enemyWave--;
            temp.SetActive(true);
        }
    }
}
