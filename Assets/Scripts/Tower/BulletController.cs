using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed*Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "ImpactArea":
                collision.collider.transform.root.gameObject.GetComponent<WaveController>().life -= 1;
                Destroy(this.gameObject);
            break;
        }
    }
}
