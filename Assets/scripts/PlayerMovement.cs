using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MaxSpeed;
    public Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        this.CapSpeed();
    }

    void CapSpeed()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVelocity.magnitude > MaxSpeed)
        {
            Vector3 cappedVelocity = flatVelocity.normalized * MaxSpeed;
            rb.velocity = new Vector3(cappedVelocity.x, rb.velocity.y, cappedVelocity.z);
        }
    }

    private void FixedUpdate()
    {
        Vector3 direction = this.transform.forward * verticalInput + this.transform.right * horizontalInput;
        rb.AddForce(direction.normalized * MaxSpeed, ForceMode.Force);
    }
}
