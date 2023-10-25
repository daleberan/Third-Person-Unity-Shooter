using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpitter : MonoBehaviour
{
    public Rigidbody enemy;
    public float speed = 2;
    public float Timer = 5;


    void spitEnemy()
    {

        Rigidbody enemyClone = (Rigidbody)Instantiate(enemy, transform.position, transform.rotation);
        enemyClone.velocity = transform.right * speed;


    }


    void Update()
    {


        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            spitEnemy();
            Timer = 5f;

        }
    }
}
