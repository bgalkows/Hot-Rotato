using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalBackAndForth : MonoBehaviour
{
    public int[] frames = new int[3];
    private int[] framesLeft = new int[3];
    public float[] speed = new float[3];
    public bool[] XYZ_Boolean_Array = new bool[3];
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            framesLeft[i] = frames[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (XYZ_Boolean_Array[0]) { transform.Translate(speed[0], 0, 0); }
        if (XYZ_Boolean_Array[1]) { transform.Translate(0, speed[1], 0); }
        if (XYZ_Boolean_Array[2]) { transform.Translate(0, 0, speed[2]); }

        for (int i = 0; i < 3; i++)
        {
            framesLeft[i] -= 1;
            if (framesLeft[i] == 0)
                framesLeft[i] = frames[i];
        }
    }
}
