using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    private Rigidbody rigid;
    // Use this for initialization
    private float mass = 3.0f; // defines the character mass
    private Vector3 impact = Vector3.zero;
    private CharacterController character;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
    }

    // call this function to add an impact force:
    void AddImpact(Vector3 dir, float force)
    {
        dir.Normalize();
        dir.y = 0; // reflect down force on the ground
        impact += dir.normalized * force / mass;
    }

    void Update()
    {
        // apply the impact force:
        if (impact.magnitude > 0.2) character.Move(impact * Time.deltaTime);
        // consumes the impact energy each cycle:
        impact = Vector3.Lerp(impact, Vector3.zero, 5 * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag != "Platform" && hit.collider.attachedRigidbody != null && !hit.collider.attachedRigidbody.isKinematic)
        {
            Debug.Log(rigid.position.y - hit.collider.attachedRigidbody.position.y);
            //if (rigid.position.y - hit.collider.attachedRigidbody.position.y <= 1)
            AddImpact(new Vector3(-hit.collider.attachedRigidbody.velocity.x, 0, -hit.collider.attachedRigidbody.velocity.z), 80);
        }
    }
}
