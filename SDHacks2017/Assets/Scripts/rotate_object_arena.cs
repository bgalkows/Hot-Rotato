using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_object_arena : MonoBehaviour {
    public float speed = 20;
    public GameObject player;
    public bool increasingOverTime = false, aroundPlatform = false;

    [SerializeField]
    private float _forceStrength;
    Rigidbody rb;

    private float timer;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //transform.RotateAround(player.transform.position, Vector3.up, speed * Time.deltaTime);
        rb.AddForceAtPosition(Vector2.one * _forceStrength, player.transform.position);
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = (player.transform.position - rb.position).normalized;
        Vector3 rotation = Quaternion.AngleAxis(horizontal * 60, Vector3.up) * direction * Mathf.Abs(horizontal);
        Vector3 desired = rotation + vertical * direction;
        Vector3 change = desired * speed - rb.velocity;

        rb.AddForce(change * Time.deltaTime, ForceMode.VelocityChange);
    }

    void checkTimeForIncrement()
    {

    }
}