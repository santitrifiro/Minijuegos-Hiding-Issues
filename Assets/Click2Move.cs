using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Click2Move : MonoBehaviour
{
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray MoveTo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(MoveTo, out var hitInfo))
            {
                agent.SetDestination(hitInfo.point);
            }
        }
        
    }
}
