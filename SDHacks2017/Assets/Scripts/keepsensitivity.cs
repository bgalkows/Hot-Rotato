using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepsensitivity : MonoBehaviour {

    public changesensitivity sens;
    public float keep_value;
	// Use this for initialization
	void Start () {
        sens = GameObject.FindGameObjectWithTag("SensitivitySlider").GetComponent<changesensitivity>();
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(sens);
        keep_value = sens.mouseSensitivity;
	}
}
