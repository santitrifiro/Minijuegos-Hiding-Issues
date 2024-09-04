using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Tyrone,
    Jack,
    Emma,
    Walter
}


public class Player : MonoBehaviour
{

    public Character character;
    private Room currentRoom;

    // Start is called before the first frame update
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if ( currentRoom != null ) {
                Debug.Log("Te escondess en " + currentRoom.name);
            }
        }
    }

    public void EnteredRoom(Room room)
    {
        currentRoom = room;
    }

    public void ExitedRoom(Room room)
    {
        currentRoom = null;
    }


}
