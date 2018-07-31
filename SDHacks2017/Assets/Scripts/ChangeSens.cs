using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSens : MonoBehaviour {

    public float sensitivity = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxisRaw("Mouse X"));
        Debug.Log(Input.GetAxisRaw("Mouse Y"));
    }

    public void AdjustSensitivity(float newSensitivity)
    {
        sensitivity = newSensitivity;
    }
}
