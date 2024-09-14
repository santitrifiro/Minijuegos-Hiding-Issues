using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotemParedManager : MonoBehaviour
{

    public CameraManager cm;

    public ParedPlayerManager pp;

    public ParedGameManager pgm;

    private bool visitado = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown () {

        pgm.started = true;
        pp.speed = 10f;
        cm.set3();

    }

}
