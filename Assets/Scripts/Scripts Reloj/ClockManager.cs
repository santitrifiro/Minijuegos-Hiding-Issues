using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ClockManager : MonoBehaviour
{

    public GameManager gm;

    public GameObject tmp;

    private float possibility;

    private int horas = 12;
    private int minutos = 0;
    private bool solved = false;

    public void addHoras () {

        this.horas++;

        if (horas > 12) {

            horas = 1;

        }

    }

    public void addMinutos () {

        this.minutos += 5;

        if (minutos > 55) {

            minutos = 0;

        }

    }

    public bool isSolved () {

        return solved;

    }

    public float getPossibility () {

        return possibility;

    }

    public void activeTMP () {

        tmp.SetActive(true);

    }

    // Start is called before the first frame update
    void Start()
    {
        tmp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        bool solved = gm.compareTimes(horas, minutos);
        gm.setSolved(solved);
        this.solved = solved;

        if (Input.GetKeyDown(KeyCode.Escape)) {

            tmp.SetActive(false);

        }

    }
}
