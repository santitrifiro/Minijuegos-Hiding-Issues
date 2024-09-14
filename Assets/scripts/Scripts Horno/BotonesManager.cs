using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BotonesManager : MonoBehaviour
{
    
    public HornoManager hm;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown () {

        Debug.Log("tocado");

        if (this.CompareTag("perilla1")) {

            hm.setnv1();

        }

        if (this.CompareTag("perilla2")) {

            hm.setnv2();

        }

        if (this.CompareTag("perilla3")) {

            hm.setnv3();

        }

        if (this.CompareTag("perilla4")) {

            hm.setnv4();

        }

    }

}
