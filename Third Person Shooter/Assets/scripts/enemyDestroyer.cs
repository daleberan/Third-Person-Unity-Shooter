using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class enemyDestroyer : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MyEnemy"))
        {
            Destroy(other.gameObject);
            GameObject.Find("gameController").GetComponent<gameStats>().Score++;
        }

    }
}


