using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMove : MonoBehaviour {
    private int[] deg = new int[3];
    public int[] rate = new int[3];
    public float[] amp = new float[3];
    public bool[] XYZ_Boolean_Array = new bool[3];
    private Rigidbody rigid;
    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
        for (int i = 0; i < 3; i++)
        {
            deg[i] = 0;
        }
	}
    private void FixedUpdate()
    {
        for (int i = 0; i < 3; i++)
        {
            deg[i] += rate[i];
            if (deg[i] == 360)
                deg[i] = rate[i];
        }
    }
    // Update is called once per frame
    void Update () {
        if (XYZ_Boolean_Array[0]) { rigid.MovePosition(rigid.position+Vector3.right*Mathf.Sin(Mathf.Deg2Rad*deg[0])*amp[0]*Time.deltaTime); }
        if (XYZ_Boolean_Array[1]) { rigid.MovePosition(rigid.position + Vector3.up * Mathf.Sin(Mathf.Deg2Rad * deg[1]) * amp[1]*Time.deltaTime); }
        if (XYZ_Boolean_Array[2]) { rigid.MovePosition(rigid.position + Vector3.forward * Mathf.Sin(Mathf.Deg2Rad * deg[2]) * amp[2]*Time.deltaTime); }
	}
}
