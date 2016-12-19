﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    public Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
        Debug.Log(target.position);
        
        if (GetComponentInChildren<Renderer>().isVisible)
        {
            Debug.Log("isvisible");
            agent.Stop();
        }
        else agent.Resume();
    
        
    }
}
