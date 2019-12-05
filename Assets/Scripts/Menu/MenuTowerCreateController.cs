using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTowerCreateController : MonoBehaviour
{
    public GameObject menuTower;
    public GameObject tower;
    public GameObject playerCont;
    public GameObject emptyTower;
    public GameObject sound;
    int costo = 5;
    public void createTower(){
        if(playerCont.GetComponent<PlayerController>().gold >= costo){
            playerCont.GetComponent<PlayerController>().gold -= costo;
            Instantiate(tower, emptyTower.transform.position, emptyTower.transform.rotation);
            Instantiate(sound);
            emptyTower.gameObject.SetActive(false);
            menuTower.SetActive(false);
        }
    }

    public void closeMenu(){
        menuTower.SetActive(false);
    }

    void Update(){
    }


}
