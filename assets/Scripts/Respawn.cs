﻿using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    void PlayerDeath()
    {
        //transform.position = new Vector3(0.37f, 6.64f, 28.78f);
        transform.position = Checkpoint.check;
        
        transform.localEulerAngles = new Vector3(0,0,0);
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Death" | hit.gameObject.tag == "Enemy")
        {
            PlayerDeath();
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {
            PlayerDeath();
        }
    }
}
