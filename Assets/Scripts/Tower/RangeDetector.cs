using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeDetector : MonoBehaviour
{
    public GameObject sound_laser;
    TowerController tcRoot;
    float timeNextBullet;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        tcRoot =  transform.parent.gameObject.GetComponent<TowerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider obj){
        switch (obj.tag)
        {
            case "Enemy":
                target = obj.gameObject.GetComponent<WaveController>().damagePoint;
                tcRoot.towerHead.transform.LookAt(new Vector3(target.transform.position.x, obj.transform.position.y, target.transform.position.z));
                if(Time.time > timeNextBullet){
                    Instantiate(tcRoot.bulletReference, tcRoot.bulletSpawn.position, tcRoot.bulletSpawn.rotation);
                    Instantiate(sound_laser);
                    timeNextBullet = Time.time + tcRoot.fireRate;
                }
            break;
        }
    }
}
