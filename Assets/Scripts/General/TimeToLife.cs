using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLife : MonoBehaviour
{
    public float timeToLife;
    void Start()
    {
        Destroy(gameObject, timeToLife);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
