using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
    public GameObject bullet;
    public int timer = 0;

    void Update() {

       if(timer>=0) timer--;
        if (Input.GetKey(KeyCode.Space)&&timer<=0) {

            Instantiate(bullet, transform.position, Quaternion.identity);
            timer = 15;
        }
    }
}
