using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapCamera : MonoBehaviour
{

    public Transform Camera;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        Camera.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Camera.rotation = Quaternion.Euler(transform.rotation.eulerAngles);
    }
}
