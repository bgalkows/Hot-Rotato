using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forth : MonoBehaviour
{
    public float[] speed = new float[3];
    public bool[] XYZ_Boolean_Array = new bool[3];
    private Rigidbody rigid;
    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (XYZ_Boolean_Array[0]) { rigid.MovePosition(rigid.position + transform.right * speed[0] * Time.deltaTime); }
        if (XYZ_Boolean_Array[1]) { rigid.MovePosition(rigid.position + transform.up * speed[1] * Time.deltaTime); }
        if (XYZ_Boolean_Array[2]) { rigid.MovePosition(rigid.position + transform.forward * speed[2] * Time.deltaTime); }
    }
}
