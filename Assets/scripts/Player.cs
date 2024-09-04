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
    private Canvas overlay;
    private bool hiding = false;

    // Start is called before the first frame update
    void Start()
    {   
        overlay = this.GetComponentInChildren<Canvas>();
        return;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            if(hiding)
            {
                StopHiding();
            } else
            {
                Hide();
            }
        }
    }

    void Hide()
    {
        if (currentRoom != null)
        {
            Debug.Log("Te escondess en " + currentRoom.name);
            overlay.GetComponentInChildren<Fade2Black>().SlowFade();
            hiding = true;
        }
    }

    void StopHiding()
    {
        Debug.Log("Salis del escondite ");
        overlay.GetComponentInChildren<Fade2Black>().ResetFade();
        hiding = false;
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
