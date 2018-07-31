using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedBatty : MonoBehaviour {
    public bool randTimer = true;
    private Forth lineMove;
    private RotateObject rotate;
    public int setCount;
    private int countdown;
	// Use this for initialization
	void Start () {
        lineMove = GetComponent<Forth>();
        rotate = GetComponent<RotateObject>();
        if (randTimer)
            countdown = Mathf.RoundToInt(Random.value * 100);
        else
            countdown = setCount;
	}
	
	// Update is called once per frame
	void Update () {
        countdown--;
        if (countdown == 0)
        {
            if (randTimer)
            {
                countdown = Mathf.RoundToInt(Random.value * 100);
            }
            else
            {
                countdown = setCount;
            }
            if (Random.value < 0.5f)
                rotate.speed = -rotate.speed;
            lineMove.enabled = !lineMove.enabled;
            rotate.enabled = !rotate.enabled;
        }
	}
}
