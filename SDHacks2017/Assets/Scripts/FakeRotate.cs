using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * 300f *Time.deltaTime);
        transform.Rotate(Vector3.right * 250f * Time.deltaTime);
	}
}
