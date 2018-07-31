using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class chaseplayer : MonoBehaviour {
    public Transform Player;
    public float speed;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;  
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;

        if (Physics.Raycast(transform.position, Player.transform.position, 500) == false)
        {
            transform.LookAt(Player);
            transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
        }
        else
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), step);
    }
}
 