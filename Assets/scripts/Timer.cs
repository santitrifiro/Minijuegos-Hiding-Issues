using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;

public class Timer : MonoBehaviour
{

    public double TiempoDeEscondite;
    private double TiempoRestante;
    private bool SeAcaboElTiempo;

    // Start is called before the first frame update
    void Start()
    {
        TiempoRestante = TiempoDeEscondite;
        SeAcaboElTiempo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!SeAcaboElTiempo)
        {
            TiempoRestante -= Time.deltaTime;
            SeAcaboElTiempo = TiempoRestante <= 0;
        }

    }

    bool SeAcaboElTiempoDeEscondite()
    {
        return SeAcaboElTiempo;
    }
}
