﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCursorAppear : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        UnityEngine.Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
