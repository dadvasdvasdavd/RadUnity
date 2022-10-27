using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsScript : MonoBehaviour
{
    Rigidbody ourRigidBody;
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ourRigidBody.AddExplosionForce(25, transform.position + Vector3.left, 1);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ourRigidBody.AddExplosionForce(25, transform.position + Vector3.right, 1);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }
}
