using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CompleteRandom : MonoBehaviour {
    
    public float speed = 20;
    public int timer;
    float counter;
    int decision;
    int direction;
    int number;
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        if (Time.frameCount % 30 == 0)
        {
            int decision = Random.Range(0, 2);

            int direction = Random.Range(0, 2);
            if (direction == 0)
            {
                direction = 1;
            }
            else
            {
                direction = -1;
            }
            if (decision == 0)
            {
                transform.Translate(direction * speed * Time.deltaTime, 0, 0);
            }
            else
            {

                transform.Translate(0, 0, speed * Time.deltaTime * direction);
            }
        }
        
        
        //counter += Time.deltaTime;
        //if (counter >=timer)
        //{
        
          //  counter = 0;
        //}
	}
}
