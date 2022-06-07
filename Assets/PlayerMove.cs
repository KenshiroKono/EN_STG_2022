using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMove : MonoBehaviour
{

    public float power = 0.2f;
    void Start()
    {
     
    }
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.W)) {
            pos.z += power;
        }
        else if (Input.GetKey(KeyCode.S)) {
            pos.z -= power;
        }
        if (Input.GetKey(KeyCode.D)) {
            pos.x += power;
        }
        else if (Input.GetKey(KeyCode.A)) {
            pos.x -= power;
        }

        transform.position=new Vector3(pos.x, pos.y, pos.z);
    }
}
