using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class FakeScript : MonoBehaviour
{
    public float speed = 6;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Rigidbody2DMovement();
    }	
     // Move by Transform Position 
    void TransformMovement()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed * Time.deltaTime;

        transform.position += velocity;
    }
    void Rigidbody2DMovement()
    {
        // Move by Rigidbody2D Velocity
        Vector3 inputDir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        rb.velocity = inputDir * speed * Time.fixedDeltaTime;
    }
}
