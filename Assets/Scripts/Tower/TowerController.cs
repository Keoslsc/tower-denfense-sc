using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    // Referencias visuales
    public GameObject towerHead;
    public GameObject canon;
    public GameObject rangeAttackObject;
    public GameObject bulletReference;
    public GameObject playerCont;
    public Transform bulletSpawn;

    // Propiedades
    int damage;
    public float rangeAttack;
    public float fireRate;
    
    // Start is called before the first frame update
    void Start()
    {
        rangeAttackObject.GetComponent<CapsuleCollider>().radius = rangeAttack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
