using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTowerCreate : MonoBehaviour
{
    public GameObject menuTower;
    public GameObject emptyTower;
    // Update is called once per frame
    void Start(){
        
    }

    void Update()
    {
        
        
    }

    void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){
            menuTower.SetActive(true);
            menuTower.transform.GetChild(0).transform.GetComponent<MenuTowerCreateController>().emptyTower = emptyTower;
        };
    }
}
