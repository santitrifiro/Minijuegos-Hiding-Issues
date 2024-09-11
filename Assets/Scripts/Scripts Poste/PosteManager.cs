using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.PackageManager;
using UnityEditor;

public class PosteManager : MonoBehaviour
{
    
    public int number = -1;
    public bool[] ns = new bool[8];

    public bool isOn (int i) {

        if (i >= 0 && i <= 7) {

            return ns[i];

        } else {

            return false;

        }

    }

    void Awake()
    {
        System.Random random = new System.Random();
        number = random.Next(0, 256);

        int aux = number;

        for (int i = 7; i >= 0; i--) {

            int p = (int) Math.Pow(2, i);

            if (aux >= p) {

                ns[7 - i] = true;
                aux -= p;

            } else {

                ns[7 - i] = false;

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
