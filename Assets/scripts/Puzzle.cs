using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Room))]
public abstract class Puzzle : MonoBehaviour
{
    private Room room;
    // Start is called before the first frame update
    void Start()
    {
        room = this.GetComponent<Room>();
    }

    void OnSolve()
    {
        room.RevealSecurityPercentage();
    }
}
