using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heightCapture : MonoBehaviour {
    public Text text;
    public GameObject player;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        text.text = ""+(int)player.transform.position.y;
	}
}
