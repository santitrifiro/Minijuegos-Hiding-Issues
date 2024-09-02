using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{

    public int SecurityPercentage;
    public Vector3 center;
    public Vector3 size;
    private bool HasPlayerInside;
    private Vector3 PlayerPosition;

    private Vector3 trueCenter;
    private Vector3 trueSize;

    // Start is called before the first frame update
    void Start()
    {
        trueCenter = transform.position + center; 
        trueSize = Vector3.Scale(Vector3.Scale(transform.localScale, size), new Vector3(0.5f, 0.5f, 0.5f));
        return;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HasPlayerInside = " + HasPlayerInside);
        Collider[] hitColliders = Physics.OverlapBox(trueCenter, trueSize);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].TryGetComponent<Player>(out var component))
            {
                HasPlayerInside = true;
                PlayerPosition = component.transform.position;
                return;
            }
        }

        HasPlayerInside = false;
    }
}
