using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
    public Camera camera1;
    public Camera camera2;

    public Camera camera3;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void set1 () {

        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        camera1.gameObject.SetActive(true);

    }

    public void set2 () {

        camera1.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);

    }

    public void set3 () {

        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(true);

    }

}
