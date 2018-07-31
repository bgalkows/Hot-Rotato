using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour {
    private float NextActionTime = 0.0f;
    public float period = 5.0f;
    public GameObject prefab;
    public int ProjectileMax = 10;
    int AllCreated = 1;
    
    // Use this for initialization
    void Start() { 
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > NextActionTime)
        {

           
            NextActionTime += period;
            Instantiate(prefab, transform);
            AllCreated++;

            if (AllCreated > ProjectileMax)
            {
                
                Destroy(this.gameObject.transform.GetChild(0).gameObject);
            }
        }
	}
}
