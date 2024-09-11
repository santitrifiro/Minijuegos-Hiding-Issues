using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private float clock_possibility;

    public int x;
    public int y;

    private bool solved = false;

    public void setSolved (bool solved) {

        this.solved = solved;

    }

    public bool isSolved () {

        return solved;

    }

    public bool compareTimes (int x_input, int y_input) {

        bool v1 = x == x_input;
        bool v2 = y == y_input;

        return v1 && v2;

    } 

    public float getClockPossibility () {

        return clock_possibility;

    }

    void Awake()
    {
        clock_possibility = (float) new System.Random().NextDouble();

        System.Random random = new System.Random();
        int randomx = random.Next(1, 11);
        int randomy = 5 * random.Next(1, 11);

        x = randomx;
        y = randomy;
    }

    void Update()
    {
        
    }
}
