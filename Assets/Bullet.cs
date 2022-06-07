using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += 0.4f;
        transform.position = new Vector3(pos.x,pos.y,pos.z);

        if(pos.z>=20){
            Destroy(gameObject);
        }
    }
}
