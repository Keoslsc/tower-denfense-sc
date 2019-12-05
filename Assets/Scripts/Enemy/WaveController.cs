using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Transform damagePoint;
    public GameObject explotionReference;
    public GameObject playerCont;
    public int gold;
    public int life;
    void Start(){
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }

    void Update(){
        if(life > 0){
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else if(life <= 0){
            Destroy(this.gameObject);
            this.gameObject.GetComponent<Collider>().enabled = false;
            GameObject explotion = Instantiate(explotionReference, transform.position, transform.rotation);
            playerCont.GetComponent<PlayerController>().gold += gold;
            playerCont.GetComponent<PlayerController>().enemies -= 1;
            
        }
    }

    void OnTriggerEnter(Collider obj){
        switch (obj.tag)
        {
            case "WavePoint":
                int randPoint = Random.Range(0, obj.gameObject.GetComponent<WavePoint>().nextPoint.Length);
                target = obj.gameObject.GetComponent<WavePoint>().nextPoint[randPoint];
                transform.LookAt(new Vector3(target.position.x, target.position.y, target.position.z));
            break;
            case "Player":
                 Destroy(this.gameObject);
                 this.gameObject.GetComponent<Collider>().enabled = false;
                 GameObject explotion = Instantiate(explotionReference, transform.position, transform.rotation);
                 playerCont.GetComponent<PlayerController>().life -= 1;
                 playerCont.GetComponent<PlayerController>().enemies -= 1;
            break;
        }
    }
}
