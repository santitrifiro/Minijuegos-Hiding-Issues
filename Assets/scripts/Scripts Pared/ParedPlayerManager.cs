using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ParedPlayerManager : MonoBehaviour
{
    
    public bool alive = true;

    private float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(this.speed * x, 0, this.speed * z);

        if (this.alive == false) {

            this.GetComponent<Renderer>().material.color = Color.red;

        }

    }

}
