using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    [Header("Rigid Body")]
    public float Mass = 1;
    public float Drag = 5;
    public float AngularDrag = 0.05f;
    private bool AutomaticCenterOfMass = true;
    private bool AutomaticTensor = true;
    private bool UseGravity = true;
    private bool IsKinematic = false;
    private RigidbodyInterpolation Interpolate = RigidbodyInterpolation.Interpolate;
    private CollisionDetectionMode CollisionDetection = CollisionDetectionMode.Continuous;
    // Constrains
    // Layer Overrides

    [Header("First Person Camera")]
    public float SensibilityX = 250;
    public float SensibilityY = 250;

    [Header("Player Movement")]
    public float MaxSpeed = 70;


    private Room currentRoom;
    private Canvas overlay;
    public bool hiding = false;
    private List<Room> SolvedRooms = new List<Room>();

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.AddComponent<Rigidbody>();
        rb.mass = Mass;
        rb.drag = Drag;
        rb.angularDrag = AngularDrag;
        rb.automaticCenterOfMass = AutomaticCenterOfMass;
        rb.automaticInertiaTensor = AutomaticTensor;
        rb.useGravity = UseGravity;
        rb.isKinematic = IsKinematic;
        rb.interpolation = Interpolate;
        rb.collisionDetectionMode = CollisionDetection;

        PlayerCamera cameraManager = this.AddComponent<PlayerCamera>();
        cameraManager.sensibilityX = SensibilityX;
        cameraManager.sensibilityY = SensibilityY;
        cameraManager.Camera = this.GetComponentInChildren<SnapCamera>().gameObject; //Agarra el snap que ata a la camara

        PlayerMovement playerMovement = this.AddComponent<PlayerMovement>();
        playerMovement.MaxSpeed = MaxSpeed;
        playerMovement.rb = rb;

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
            } 
            else
            {
                Hide();
            }
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            if (currentRoom != null && !SolvedRooms.Contains(currentRoom))
            {
                SolvedRooms.Add(currentRoom);
                overlay.GetComponentInChildren<SecurityPercentageUI>().SetSecurityPercentage(currentRoom.SecurityPercentage);
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
        if (SolvedRooms.Contains(room))
        {
            overlay.GetComponentInChildren<SecurityPercentageUI>().SetSecurityPercentage(room.SecurityPercentage);
        } else
        {
            overlay.GetComponentInChildren<SecurityPercentageUI>().UnknownSecurityPercentage();
        }
        currentRoom = room;
    }

    public void ExitedRoom(Room room)
    {
        overlay.GetComponentInChildren<SecurityPercentageUI>().VoidSecurityPercentage();
        currentRoom = room == currentRoom ? null : currentRoom;
    }

    public bool IsHiding()
    {
        return hiding;
    }

    public Room GetCurrentRoom()
    {
        return currentRoom;
    }

    public void Immobilize()
    {
        PlayerMovement playerMovement = GetComponent<PlayerMovement>();

        if (playerMovement != null)
        {
            playerMovement.enabled = false;  // Desactiva el movimiento
            Debug.Log("Movimiento deshabilitado.");
        }
    }

    public void Mobilize()
    {
        PlayerMovement playerMovement = GetComponent<PlayerMovement>();

        if (playerMovement != null)
        {
            playerMovement.enabled = true;  // Activa nuevamente el movimiento
            Debug.Log("Movimiento habilitado.");
        }
    }


}
