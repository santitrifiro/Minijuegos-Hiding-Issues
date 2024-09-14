using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotemBallManager : MonoBehaviour
{

    public CameraManager cm;
    public BallMovementManager bm;

    private bool visitado = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown () {

        if (!visitado) {

            visitado = true;
            cm.set2();
            bm.speed = 4f;

        }

    }

}
