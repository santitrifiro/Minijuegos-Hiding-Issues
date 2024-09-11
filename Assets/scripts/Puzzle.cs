using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Room))]
public abstract class Puzzle : MonoBehaviour
{
    private Room room;

    protected void StartPuzzle()
    {
        room = this.GetComponent<Room>();
    }

    void OnSolve()
    {
        room.RevealSecurityPercentage();
    }
}
