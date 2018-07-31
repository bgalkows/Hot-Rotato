using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableHitBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
