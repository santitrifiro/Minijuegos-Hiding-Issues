using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public int SecurityPercentage;
    public BoxCollider box;
    private List<Player> PlayersInside;

    // Start is called before the first frame update
    void Start()
    {
        box.isTrigger = true;
        PlayersInside = new List<Player>();
        return;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.TryGetComponent<Player>(out Player player))
        {
            player.EnteredRoom(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name);
        if (other.TryGetComponent<Player>(out Player player))
        {
            player.ExitedRoom(this);
        }
    }
}
