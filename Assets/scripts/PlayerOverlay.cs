using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

[RequireComponent(typeof(Canvas))]
public class PlayerOverlay : MonoBehaviour
{

    private Fade fadeComponent;
    private SecurityPercentageUI securityComponent;
    // Start is called before the first frame update
    void Start()
    {
        Canvas canvas = this.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler scaler = this.AddComponent<CanvasScaler>();
        GraphicRaycaster raycaster = this.AddComponent<GraphicRaycaster>();

        fadeComponent = this.GetComponentInChildren<Fade>();
        securityComponent = this.GetComponentInChildren<SecurityPercentageUI>();
    }
    public void Fade()
    {
        fadeComponent.StartFade();
    }

    public void ResetFade()
    {
        fadeComponent.ResetFade();
    }

    public void SetSecurityPercentage(int? newPercentage)
    {
        if (newPercentage.HasValue)
        {
            Debug.Log("hi" + newPercentage);
            securityComponent.SetSecurityPercentage(newPercentage.Value);
        } else
        {
            securityComponent.UnknownSecurityPercentage();
        }
    }

    public void VoidSecurityPercentage()
    {
        securityComponent.VoidSecurityPercentage();
    }
}
