using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedParedManager : MonoBehaviour
{
    
    public ParedPlayerManager ppm;

    private Rigidbody p_rb;

    void Start()
    {
        this.p_rb = ppm.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) {

        if (other.CompareTag("Player")) {

            bool en_movimiento = (this.p_rb.velocity.x != 0) || (this.p_rb.velocity.z != 0);

            if (en_movimiento) {

                if (this.CompareTag("still")) {

                    ppm.alive = false;

                }

            } else {

                if (this.CompareTag("move")) {

                    ppm.alive = false;

                }

            }

        }

    }

}
