using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public float sensibilityX;
    public float sensibilityY;

    public GameObject Camera;
    private Transform camera_transform;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camera_transform = Camera.transform;
        camera_transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensibilityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensibilityY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(0, yRotation, 0);
        camera_transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        camera_transform.position = new Vector3(transform.position.x, camera_transform.position.y, transform.position.z);
    }
}
