using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 5f;

    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        this.cc = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        
        Vector3 new_movement = new Vector3(x, 0, z);

        new_movement = this.transform.TransformDirection(new_movement);
        new_movement.y = 0;

        cc.Move(new_movement * speed * Time.deltaTime);

    }

}
