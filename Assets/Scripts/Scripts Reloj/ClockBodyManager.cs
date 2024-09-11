using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockBodyManager : MonoBehaviour
{

    public ClockManager cm;

    void Start()
    {
        
    }

    void Update()
    {
        if (cm.isSolved()) {

            GetComponent<Renderer>().material.color = Color.green;

        } else {

            GetComponent<Renderer>().material.color = Color.gray;

        }
    }

    private void OnMouseDown () {

        if (cm.isSolved()) {

            cm.activeTMP();

        }

    }

}
