using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changesensitivity : MonoBehaviour {

    public float mouseSensitivity = 2f;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeSensitivity(float newSensitivity)
    {
        mouseSensitivity = newSensitivity;
    }
}
