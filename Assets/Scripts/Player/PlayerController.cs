using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int waves = 8;
    public int gold = 12;
    public int life = 15;
    public int enemies = 1;
    public float timeForNextWave = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemies == 0 && waves > 0){
            waves--;
            enemies = 4;
        }

    }
}
