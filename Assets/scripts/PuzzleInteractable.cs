using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleInteractable : MonoBehaviour
{
    public Puzzle ReportBackTo;

    public void WhenInteracted()
    {
        Debug.Log("interacted" + this.gameObject);
        ReportBackTo.HandleComponentInteracted(this);
    }

    public static PuzzleInteractable AddPuzzleInteractable(GameObject victim, Puzzle report_to)
    {
        PuzzleInteractable component = victim.AddComponent<PuzzleInteractable>();
        component.ReportBackTo = report_to;
        return component;
    }
}
