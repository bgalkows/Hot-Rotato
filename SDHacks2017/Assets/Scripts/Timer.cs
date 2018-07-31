using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    
    private float StartTime;
    public Text TimerText;
    public bool done = false;
	// Use this for initialization
	void Start () {
        
        StartTime = Time.time;
        
	}

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - StartTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;
        
        
        if (done)
        {

            StartCoroutine("delay");
        }
    }
    IEnumerator delay()
    {
        enabled = false;
        yield return new WaitForSeconds(2f);
        TimerText.GetComponent<Text>().enabled = false;
    }
}
