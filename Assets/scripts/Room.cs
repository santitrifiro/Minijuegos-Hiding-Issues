using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public int SecurityPercentage;
    public BoxCollider box;

    // Start is called before the first frame update
    void Start()
    {
        box.isTrigger = true;
        return;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Player player = other.GetComponentInParent<Player>();

        if (player != null)
        {
            player.EnteredRoom(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other);
        Player player = other.GetComponentInParent<Player>();

        if (player != null)
        {
            player.ExitedRoom(this);
        }
    }
}
