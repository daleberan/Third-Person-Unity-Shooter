using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpitter : MonoBehaviour
{
    public Rigidbody bullet;
    public float speed = 10;
 


    void spitBullet()
    {

        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.right * speed;

    }


    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            spitBullet();
        }


    }

}



