using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour {
    public int[] frames = new int[3];
    private int[] framesLeft = new int[3];
    public float[] speed = new float[3];
    public bool[] XYZ_Boolean_Array = new bool[3];
    private Rigidbody rigid;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
        for (int i = 0; i < 3; i++)
        {
            framesLeft[i] = frames[i];
        }
	}

    // Update is called once per frame
    void Update() {
        if (XYZ_Boolean_Array[0]) { rigid.MovePosition(rigid.position+transform.right*speed[0]*Time.deltaTime); }
        if (XYZ_Boolean_Array[1]) { rigid.MovePosition(rigid.position+transform.up*speed[1] * Time.deltaTime); }
        if (XYZ_Boolean_Array[2]) { rigid.MovePosition(rigid.position+transform.forward*speed[2] * Time.deltaTime); }
    }
    private void FixedUpdate()
    { 
        for (int i = 0; i < 3; i++)
        {
            framesLeft[i] -= 1;
            if (framesLeft[i] == 0)
            {
                speed[i] = -speed[i];
                framesLeft[i] = frames[i];
            }
        }
    }
}
