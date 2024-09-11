using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoManager : MonoBehaviour
{
    
    public HornoManager hm;

    private double scale_unit = 0.5;
    private double position_unit = 0.25;

    private float initial_scale = (float) 0.5;
    private float initial_position;

    void Start()
    {
        
        initial_position = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {

        int x = 1;

        if (this.CompareTag("fuego1")) {

            x = hm.nv1 - 1;

        } else if (this.CompareTag("fuego2")) {

            x = hm.nv2 - 1;

        } else if (this.CompareTag("fuego3")) {

            x = hm.nv3 - 1;

        } else if (this.CompareTag("fuego4")) {

            x = hm.nv4 - 1;

        }

        Vector3 escala = new Vector3(1, (float) (initial_scale + x * scale_unit), 1);
        transform.localScale = escala;
        transform.position = new Vector3(transform.position.x, (float) (initial_position + x * position_unit), transform.position.z);
        
    }
}
